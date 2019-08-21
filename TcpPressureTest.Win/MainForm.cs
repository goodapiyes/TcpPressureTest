using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azylee.Core.IOUtils.TxtUtils;
using BeetleX;
using BeetleX.Clients;
using Microsoft.Win32;
using TcpPressureTest.Win.Utility;


namespace TcpPressureTest.Win
{
    public partial class MainForm : Form
    {
        private static object locker = new object();
        private List<AsyncTcpClient> _clients= new List<AsyncTcpClient>();
        private bool _loopConStatus = true;
        private bool _loopStatus = true;
        private Task _connecTask;
        private string sendData = "hello world\r\n";
        public MainForm()
        {
            InitializeComponent();
            //装载配置
            InstallAppConfig();
        }

        #region 功能函数

        private void InitStatus()
        {
            _loopConStatus = true;
            _loopStatus = true;
            _clients = new List<AsyncTcpClient>();
            btnPause.Enabled = false;
        }
        private void InstallAppConfig()
        {
            tbIP.Text = ConfigTool.Get("ip");
            tbPort.Text = ConfigTool.Get("port");
            tbInterval.Text = ConfigTool.Get("interval");
            tbConCount.Text = ConfigTool.Get("connect");
            tbData.Text= ConfigTool.Get("senddata");
        }
        private void UpdateAppConfig()
        {
            ConfigTool.Set("ip", tbIP.Text);
            ConfigTool.Set("port", tbPort.Text);
            ConfigTool.Set("interval", tbInterval.Text);
            ConfigTool.Set("connect", tbConCount.Text);
            ConfigTool.Set("senddata", tbData.Text);
        }
        private Task ConnectServer()
        {
            _connecTask = Task.Run(() =>
            {

                var ip = tbIP.Text;
                var port = tbPort.Text.ToInt();
                var con = tbConCount.Text.ToInt();
                for (int i = 0; i < con; i++)
                {
                    if (!_loopConStatus)
                        break;
                    AsyncTcpClient client = SocketFactory.CreateClient<AsyncTcpClient>(ip, port);
                    client.ClientError = (o, e) =>
                    {
                        ControlIncrement(lbErrorCount);
                        ControlAssign(lbErrorMsg, e.Message);
                    };
                    client.Receive = (o, e) =>
                    {
                        string data = e.Stream.ToPipeStream().ReadToEnd();
                        ControlIncrement(lbReceiveDataCount);

                    };
                    client.Connected = (c) =>
                    {
                        ControlIncrement(lbClientCount);
                        _clients.Add(client);
                    };
                    client.Connect();
                }

                ControlDelegate(btnPause, () => { if(!btnStart.Enabled){ btnPause.Enabled = true; } });
                ControlDelegate(btnPause, () => { btnStop.Enabled = true; });
            });

            return _connecTask;
        }
        private void SendData()
        {
            if(!string.IsNullOrWhiteSpace(tbData.Text))
                sendData = tbData.Text;
            sendData = System.Text.RegularExpressions.Regex.Unescape(sendData);
            foreach (var client in _clients)
            {
                Task task = Task.Run(() =>
                {
                    try
                    {
                        var pipestream = client.Stream.ToPipeStream();
                        var interval = this.tbInterval.Text.ToInt();
                        while (_loopStatus)
                        {
                            Thread.Sleep(interval < 100 ? 100 : interval);
                            var data = pipestream.ReadToEnd();
                            pipestream.WriteUTF(sendData);
                            pipestream.Flush();
                            ControlIncrement(lbSendDataCount);
                        }
                    }
                    catch (Exception e)
                    {
                        ControlIncrement(lbErrorCount);
                        ControlAssign(lbErrorMsg, e.Message);
                    }
                });
            }
        }
        private void ControlDelegate(Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() =>
                {
                    action.Invoke();
                }));
            }
            else
                action.Invoke();
        }
        private void ControlEnabled(Control control, bool b)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() =>
                {
                    control.Enabled = b;
                }));
            }
            else
                control.Enabled = b;
        }
        private void ControlIncrement(Control control)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() =>
                {
                    control.Text = (control.Text.ToInt() + 1).ToString();
                }));
            }
            else
                control.Text = (control.Text.ToInt() + 1).ToString();
        }
        private void ControlAssign(Control control, object value)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() =>
                {
                    control.Text = value.ToString();
                }));
            }
            else
                control.Text = value.ToString();
        }
        private void BtnPauseRest()
        {
            btnPause.Text = "Pause";
            btnPause.Enabled = false;
        }

        private void DisConnectCliets()
        {

            for (int i = _clients.Count - 1; i >= 0; i--)
            {
                _clients[i].DisConnect();
                _clients.Remove(_clients[i]);
                ControlAssign(lbClientCount, _clients.Count);
            }

            if (_clients.Count > 0)
                DisConnectCliets();
        }
        #endregion

        #region 控件事件

        private void btnStart_Click(object sender, EventArgs eventArgs)
        {
            try
            {
                //保存用户当前操作配置数据
                UpdateAppConfig();
                //初始化程序状态
                InitStatus();
                //连接服务器
                var task = ConnectServer();
                //发送数据包
                task.ContinueWith(t => { SendData(); });
                btnStart.Enabled = false;
                btnStop.Enabled = true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                ControlAssign(lbErrorMsg, e.Message);
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            if (_loopStatus)
            {
                _loopStatus = false;
                Thread.Sleep(1000);
                this.btnPause.Text = "Continue";
            }
            else
            {
                _loopStatus = true;
                Thread.Sleep(1000);
                this.btnPause.Text = "Pause";
                SendData();
            }
            btnPause.Enabled = true;
        }
        private void btnStop_Click(object sender, EventArgs eventArgs)
        {
            try
            {
                btnStop.Enabled = false;
                btnStop.Text = "Stopping...";
                _loopConStatus = false;
                _loopStatus = false;
                Thread.Sleep(1000);
                DisConnectCliets();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                ControlAssign(lbErrorMsg, e.Message);
            }
            finally
            {
                BtnPauseRest();
                btnStop.Text = "Stop";
                btnStop.Enabled = true;
                btnStart.Enabled = true;
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loopStatus = false;
            if (_clients.Count > 0)
            {
                for (int i = _clients.Count - 1; i >= 0; i--)
                {
                    _clients[i].DisConnect();
                    _clients.Remove(_clients[i]);
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            BtnPauseRest();
            btnStop.Enabled = false;
            var tcpPort = UtilityExtension.GetValue(RegistryHive.LocalMachine,
                @"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "MaxUserPort", RegistryValueKind.DWord);
            if (string.IsNullOrWhiteSpace(tcpPort))
            {
                SwitchCrack.Enabled = true;
                SwitchCrack.Checked = false;
            }
            else
            {
                SwitchCrack.Enabled = false;
                SwitchCrack.Checked = true;
                lbCrack.Visible = true;
                lbCrack.Text = $"System cracked,Max Port Count for {tcpPort}";
            }
        }
        private void SwitchCrack_CheckedChanged(object sender, EventArgs e)
        {
            if (SwitchCrack.Checked)
            {
                var tcpPort = UtilityExtension.GetValue(RegistryHive.LocalMachine,
                    @"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "MaxUserPort", RegistryValueKind.DWord);
                if (string.IsNullOrWhiteSpace(tcpPort))
                {
                    if (UtilityExtension.SetValue(RegistryHive.LocalMachine,
                        @"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "MaxUserPort", "20000",
                        RegistryValueKind.DWord))
                    {

                        lbCrack.Visible = true;
                        lbCrack.Text = $"System cracked,Max Port Count for 20000";
                        MessageBox.Show("Crack Success!");

                    }
                }
            }
        }

        #endregion

    }
}

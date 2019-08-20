using System;
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
using TcpPressureTest.Win.Utility;


namespace TcpPressureTest.Win
{
    public partial class MainForm : Form
    {
        private static object locker = new object();
        private int errorCount = 0;
        private int sendCount = 0;
        private int receiveCount = 0;
        private List<AsyncTcpClient> clients= new List<AsyncTcpClient>();
        private bool loopConStatus = true;
        private bool loopStatus = true;
        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            this.tbIP.Text = ConfigTool.Get("ip");
            this.tbPort.Text = ConfigTool.Get("port");
            this.tbInterval.Text = ConfigTool.Get("interval");
        }

        private void btnStart_Click(object sender, EventArgs eventArgs)
        {


            //复位状态
            loopConStatus = true;
            loopStatus = true;

            if (clients.Count > 0)
            {
                MessageBox.Show("程序已开启,请勿重复!");
                return;
            }

            ConnectServer();

            SendData();
        }

        private void ConnectServer()
        {

            for (int i = 0; i < 100; i++)
            {
                if (!loopConStatus)
                    break;
                AsyncTcpClient client = SocketFactory.CreateClient<AsyncTcpClient>(this.tbIP.Text, this.tbPort.Text.ToInt());
                client.ClientError = (o, e) =>
                {
                    lock (locker)
                    {
                        errorCount++;
                        this.lbErrorCount.Text = errorCount.ToString();
                        loopConStatus = false;
                    }
                };
                client.Receive = (o, e) =>
                {
                    string data = e.Stream.ToPipeStream().ReadToEnd();
                    lock (locker)
                    {
                        receiveCount++;
                        this.lbReceiveDataCount.Text = receiveCount.ToString();
                    }
                };

                client.Connect();
                clients.Add(client);
                this.lbClientCount.Text = clients.Count.ToString();
            }
        }
        private void SendData()
        {
            foreach (var client in clients)
            {
                Task.Run(() =>
                {
                    try
                    {
                        var pipestream = client.Stream.ToPipeStream();
                        while (loopStatus)
                        {
                            Thread.Sleep(50);
                            var text = new string('x', 20);
                            var data = pipestream.ReadToEnd();
                            pipestream.WriteUTF(text);
                            pipestream.Flush();
                            lock (locker)
                            {
                                sendCount++;
                                this.lbSendDataCount.Text = sendCount.ToString();
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        this.lbErrorCount.Text = errorCount.ToString();
                    }
                });
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (loopStatus)
            {
                loopStatus = false;
                this.btnPause.Text = "继续发送";
            }
            else
            {
                loopStatus = true;
                this.btnPause.Text = "暂停发送";
                SendData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            loopStatus = false;

            Task.Run(() =>
            {
                for (int i = clients.Count - 1; i >= 0; i--)
                {
                    Thread.Sleep(50);
                    clients[i].DisConnect();
                    clients.Remove(clients[i]);
                    this.lbClientCount.Text = clients.Count.ToString();
                }
            });
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loopStatus = false;
            if (clients.Count>0)
            {
                for (int i = clients.Count - 1; i >= 0; i--)
                {
                    clients[i].DisConnect();
                    clients.Remove(clients[i]);
                }
            }
        }
    }
}

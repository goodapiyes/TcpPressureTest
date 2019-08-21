namespace TcpPressureTest.Win
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbErrorMsg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbClientCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbReceiveDataCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSendDataCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbErrorCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cxFlatStatusBar1 = new CxFlatUI.CxFlatStatusBar();
            this.cxFlatGroupBox1 = new CxFlatUI.CxFlatGroupBox();
            this.tbInterval = new CxFlatUI.CxFlatTextBox();
            this.tbConCount = new CxFlatUI.CxFlatTextBox();
            this.tbPort = new CxFlatUI.CxFlatTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIP = new CxFlatUI.CxFlatTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cxFlatGroupBox3 = new CxFlatUI.CxFlatGroupBox();
            this.btnStop = new CxFlatUI.Controls.CxFlatButton();
            this.btnPause = new CxFlatUI.Controls.CxFlatButton();
            this.btnStart = new CxFlatUI.Controls.CxFlatButton();
            this.cxFlatGroupBox2 = new CxFlatUI.CxFlatGroupBox();
            this.lbCrack = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbData = new CxFlatUI.CxFlatTextArea();
            this.label1 = new System.Windows.Forms.Label();
            this.SwitchCrack = new CxFlatUI.CxFlatSwitch();
            this.cxFlatGroupBox1.SuspendLayout();
            this.cxFlatGroupBox3.SuspendLayout();
            this.cxFlatGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbErrorMsg
            // 
            this.lbErrorMsg.AutoSize = true;
            this.lbErrorMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lbErrorMsg.Location = new System.Drawing.Point(253, 191);
            this.lbErrorMsg.Name = "lbErrorMsg";
            this.lbErrorMsg.Size = new System.Drawing.Size(18, 21);
            this.lbErrorMsg.TabIndex = 18;
            this.lbErrorMsg.Text = "  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Error Msg : ";
            // 
            // lbClientCount
            // 
            this.lbClientCount.AutoSize = true;
            this.lbClientCount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbClientCount.Location = new System.Drawing.Point(252, 108);
            this.lbClientCount.Name = "lbClientCount";
            this.lbClientCount.Size = new System.Drawing.Size(19, 21);
            this.lbClientCount.TabIndex = 14;
            this.lbClientCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Online Connections : ";
            // 
            // lbReceiveDataCount
            // 
            this.lbReceiveDataCount.AutoSize = true;
            this.lbReceiveDataCount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbReceiveDataCount.Location = new System.Drawing.Point(252, 65);
            this.lbReceiveDataCount.Name = "lbReceiveDataCount";
            this.lbReceiveDataCount.Size = new System.Drawing.Size(19, 21);
            this.lbReceiveDataCount.TabIndex = 10;
            this.lbReceiveDataCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Receive Count : ";
            // 
            // lbSendDataCount
            // 
            this.lbSendDataCount.AutoSize = true;
            this.lbSendDataCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbSendDataCount.Location = new System.Drawing.Point(252, 25);
            this.lbSendDataCount.Name = "lbSendDataCount";
            this.lbSendDataCount.Size = new System.Drawing.Size(19, 21);
            this.lbSendDataCount.TabIndex = 8;
            this.lbSendDataCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Send Count : ";
            // 
            // lbErrorCount
            // 
            this.lbErrorCount.AutoSize = true;
            this.lbErrorCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lbErrorCount.Location = new System.Drawing.Point(252, 148);
            this.lbErrorCount.Name = "lbErrorCount";
            this.lbErrorCount.Size = new System.Drawing.Size(19, 21);
            this.lbErrorCount.TabIndex = 6;
            this.lbErrorCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Error Count:";
            // 
            // cxFlatStatusBar1
            // 
            this.cxFlatStatusBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cxFlatStatusBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatStatusBar1.Location = new System.Drawing.Point(0, 0);
            this.cxFlatStatusBar1.Name = "cxFlatStatusBar1";
            this.cxFlatStatusBar1.Size = new System.Drawing.Size(822, 40);
            this.cxFlatStatusBar1.TabIndex = 6;
            this.cxFlatStatusBar1.Text = "TCP Performance-Testing Tool";
            this.cxFlatStatusBar1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // cxFlatGroupBox1
            // 
            this.cxFlatGroupBox1.Controls.Add(this.tbInterval);
            this.cxFlatGroupBox1.Controls.Add(this.tbConCount);
            this.cxFlatGroupBox1.Controls.Add(this.tbPort);
            this.cxFlatGroupBox1.Controls.Add(this.label13);
            this.cxFlatGroupBox1.Controls.Add(this.label12);
            this.cxFlatGroupBox1.Controls.Add(this.label11);
            this.cxFlatGroupBox1.Controls.Add(this.tbIP);
            this.cxFlatGroupBox1.Controls.Add(this.label10);
            this.cxFlatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatGroupBox1.Location = new System.Drawing.Point(12, 46);
            this.cxFlatGroupBox1.Name = "cxFlatGroupBox1";
            this.cxFlatGroupBox1.ShowText = false;
            this.cxFlatGroupBox1.Size = new System.Drawing.Size(798, 56);
            this.cxFlatGroupBox1.TabIndex = 7;
            this.cxFlatGroupBox1.TabStop = false;
            this.cxFlatGroupBox1.Text = "Configuration";
            this.cxFlatGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // tbInterval
            // 
            this.tbInterval.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbInterval.Hint = "";
            this.tbInterval.Location = new System.Drawing.Point(681, 8);
            this.tbInterval.MaxLength = 32767;
            this.tbInterval.Multiline = false;
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.PasswordChar = '\0';
            this.tbInterval.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbInterval.SelectedText = "";
            this.tbInterval.SelectionLength = 0;
            this.tbInterval.SelectionStart = 0;
            this.tbInterval.Size = new System.Drawing.Size(83, 38);
            this.tbInterval.TabIndex = 18;
            this.tbInterval.TabStop = false;
            this.tbInterval.Text = "500";
            this.tbInterval.UseSystemPasswordChar = false;
            // 
            // tbConCount
            // 
            this.tbConCount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbConCount.Hint = "";
            this.tbConCount.Location = new System.Drawing.Point(485, 8);
            this.tbConCount.MaxLength = 32767;
            this.tbConCount.Multiline = false;
            this.tbConCount.Name = "tbConCount";
            this.tbConCount.PasswordChar = '\0';
            this.tbConCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbConCount.SelectedText = "";
            this.tbConCount.SelectionLength = 0;
            this.tbConCount.SelectionStart = 0;
            this.tbConCount.Size = new System.Drawing.Size(83, 38);
            this.tbConCount.TabIndex = 17;
            this.tbConCount.TabStop = false;
            this.tbConCount.Text = "100";
            this.tbConCount.UseSystemPasswordChar = false;
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPort.Hint = "";
            this.tbPort.Location = new System.Drawing.Point(270, 8);
            this.tbPort.MaxLength = 32767;
            this.tbPort.Multiline = false;
            this.tbPort.Name = "tbPort";
            this.tbPort.PasswordChar = '\0';
            this.tbPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPort.SelectedText = "";
            this.tbPort.SelectionLength = 0;
            this.tbPort.SelectionStart = 0;
            this.tbPort.Size = new System.Drawing.Size(73, 38);
            this.tbPort.TabIndex = 16;
            this.tbPort.TabStop = false;
            this.tbPort.Text = "8888";
            this.tbPort.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(592, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 21);
            this.label13.TabIndex = 15;
            this.label13.Text = "Interval : ";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "Connections : ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Port : ";
            // 
            // tbIP
            // 
            this.tbIP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbIP.Hint = "";
            this.tbIP.Location = new System.Drawing.Point(41, 8);
            this.tbIP.MaxLength = 32767;
            this.tbIP.Multiline = false;
            this.tbIP.Name = "tbIP";
            this.tbIP.PasswordChar = '\0';
            this.tbIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbIP.SelectedText = "";
            this.tbIP.SelectionLength = 0;
            this.tbIP.SelectionStart = 0;
            this.tbIP.Size = new System.Drawing.Size(165, 38);
            this.tbIP.TabIndex = 8;
            this.tbIP.TabStop = false;
            this.tbIP.Text = "127.0.0.1";
            this.tbIP.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "IP : ";
            // 
            // cxFlatGroupBox3
            // 
            this.cxFlatGroupBox3.Controls.Add(this.btnStop);
            this.cxFlatGroupBox3.Controls.Add(this.label5);
            this.cxFlatGroupBox3.Controls.Add(this.btnPause);
            this.cxFlatGroupBox3.Controls.Add(this.lbSendDataCount);
            this.cxFlatGroupBox3.Controls.Add(this.btnStart);
            this.cxFlatGroupBox3.Controls.Add(this.lbErrorMsg);
            this.cxFlatGroupBox3.Controls.Add(this.label6);
            this.cxFlatGroupBox3.Controls.Add(this.label9);
            this.cxFlatGroupBox3.Controls.Add(this.lbReceiveDataCount);
            this.cxFlatGroupBox3.Controls.Add(this.label7);
            this.cxFlatGroupBox3.Controls.Add(this.lbClientCount);
            this.cxFlatGroupBox3.Controls.Add(this.lbErrorCount);
            this.cxFlatGroupBox3.Controls.Add(this.label3);
            this.cxFlatGroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatGroupBox3.Location = new System.Drawing.Point(12, 355);
            this.cxFlatGroupBox3.Name = "cxFlatGroupBox3";
            this.cxFlatGroupBox3.ShowText = false;
            this.cxFlatGroupBox3.Size = new System.Drawing.Size(798, 233);
            this.cxFlatGroupBox3.TabIndex = 19;
            this.cxFlatGroupBox3.TabStop = false;
            this.cxFlatGroupBox3.Text = "Configuration";
            this.cxFlatGroupBox3.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // btnStop
            // 
            this.btnStop.ButtonType = CxFlatUI.ButtonType.Danger;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStop.Location = new System.Drawing.Point(485, 148);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 43);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.TextColor = System.Drawing.Color.White;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // btnPause
            // 
            this.btnPause.ButtonType = CxFlatUI.ButtonType.Waring;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPause.Location = new System.Drawing.Point(485, 86);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(120, 43);
            this.btnPause.TabIndex = 21;
            this.btnPause.Text = "Pause";
            this.btnPause.TextColor = System.Drawing.Color.White;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.ButtonType = CxFlatUI.ButtonType.Primary;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStart.Location = new System.Drawing.Point(485, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 43);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Start";
            this.btnStart.TextColor = System.Drawing.Color.White;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cxFlatGroupBox2
            // 
            this.cxFlatGroupBox2.Controls.Add(this.lbCrack);
            this.cxFlatGroupBox2.Controls.Add(this.label2);
            this.cxFlatGroupBox2.Controls.Add(this.tbData);
            this.cxFlatGroupBox2.Controls.Add(this.label1);
            this.cxFlatGroupBox2.Controls.Add(this.SwitchCrack);
            this.cxFlatGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxFlatGroupBox2.Location = new System.Drawing.Point(12, 108);
            this.cxFlatGroupBox2.Name = "cxFlatGroupBox2";
            this.cxFlatGroupBox2.ShowText = false;
            this.cxFlatGroupBox2.Size = new System.Drawing.Size(798, 233);
            this.cxFlatGroupBox2.TabIndex = 20;
            this.cxFlatGroupBox2.TabStop = false;
            this.cxFlatGroupBox2.Text = "cxFlatGroupBox2";
            this.cxFlatGroupBox2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            // 
            // lbCrack
            // 
            this.lbCrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCrack.AutoSize = true;
            this.lbCrack.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrack.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbCrack.Location = new System.Drawing.Point(183, 18);
            this.lbCrack.Name = "lbCrack";
            this.lbCrack.Size = new System.Drawing.Size(73, 12);
            this.lbCrack.TabIndex = 22;
            this.lbCrack.Text = "System cracked";
            this.lbCrack.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "Only support for Windows";
            // 
            // tbData
            // 
            this.tbData.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbData.Hint = "";
            this.tbData.Location = new System.Drawing.Point(9, 54);
            this.tbData.MaxLength = 32767;
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.PasswordChar = '\0';
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbData.SelectedText = "";
            this.tbData.SelectionLength = 0;
            this.tbData.SelectionStart = 0;
            this.tbData.Size = new System.Drawing.Size(782, 159);
            this.tbData.TabIndex = 20;
            this.tbData.TabStop = false;
            this.tbData.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Crack Tcp Limit : ";
            // 
            // SwitchCrack
            // 
            this.SwitchCrack.AutoSize = true;
            this.SwitchCrack.Location = new System.Drawing.Point(137, 14);
            this.SwitchCrack.Name = "SwitchCrack";
            this.SwitchCrack.Size = new System.Drawing.Size(40, 20);
            this.SwitchCrack.TabIndex = 0;
            this.SwitchCrack.Text = "cxFlatSwitch1";
            this.SwitchCrack.UseVisualStyleBackColor = true;
            this.SwitchCrack.CheckedChanged += new System.EventHandler(this.SwitchCrack_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(822, 605);
            this.Controls.Add(this.cxFlatGroupBox2);
            this.Controls.Add(this.cxFlatGroupBox3);
            this.Controls.Add(this.cxFlatGroupBox1);
            this.Controls.Add(this.cxFlatStatusBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Performance-Testing Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.cxFlatGroupBox1.ResumeLayout(false);
            this.cxFlatGroupBox1.PerformLayout();
            this.cxFlatGroupBox3.ResumeLayout(false);
            this.cxFlatGroupBox3.PerformLayout();
            this.cxFlatGroupBox2.ResumeLayout(false);
            this.cxFlatGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbErrorCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSendDataCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbReceiveDataCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbClientCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbErrorMsg;
        private System.Windows.Forms.Label label9;
        private CxFlatUI.CxFlatStatusBar cxFlatStatusBar1;
        private CxFlatUI.CxFlatGroupBox cxFlatGroupBox1;
        private CxFlatUI.CxFlatTextBox tbIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private CxFlatUI.CxFlatTextBox tbInterval;
        private CxFlatUI.CxFlatTextBox tbConCount;
        private CxFlatUI.CxFlatTextBox tbPort;
        private CxFlatUI.CxFlatGroupBox cxFlatGroupBox3;
        private CxFlatUI.Controls.CxFlatButton btnStart;
        private CxFlatUI.Controls.CxFlatButton btnPause;
        private CxFlatUI.Controls.CxFlatButton btnStop;
        private CxFlatUI.CxFlatGroupBox cxFlatGroupBox2;
        private CxFlatUI.CxFlatTextArea tbData;
        private System.Windows.Forms.Label label1;
        private CxFlatUI.CxFlatSwitch SwitchCrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCrack;
    }
}


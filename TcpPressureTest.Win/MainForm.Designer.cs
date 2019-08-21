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
            this.btnStart = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbConCount = new System.Windows.Forms.TextBox();
            this.lbErrorMsg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.lbClientCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.lbReceiveDataCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSendDataCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbErrorCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 259);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 49);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(108, 45);
            this.tbIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(132, 25);
            this.tbIP.TabIndex = 1;
            this.tbIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP地址 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "端口号 : ";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(336, 45);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(119, 25);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "8888";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbConCount);
            this.groupBox1.Controls.Add(this.lbErrorMsg);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbInterval);
            this.groupBox1.Controls.Add(this.lbClientCount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.lbReceiveDataCount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbSendDataCount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbErrorCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1027, 388);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(600, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "连接数:";
            // 
            // tbConCount
            // 
            this.tbConCount.Location = new System.Drawing.Point(668, 45);
            this.tbConCount.Margin = new System.Windows.Forms.Padding(4);
            this.tbConCount.Name = "tbConCount";
            this.tbConCount.Size = new System.Drawing.Size(69, 25);
            this.tbConCount.TabIndex = 19;
            this.tbConCount.Text = "100";
            // 
            // lbErrorMsg
            // 
            this.lbErrorMsg.AutoSize = true;
            this.lbErrorMsg.Location = new System.Drawing.Point(315, 126);
            this.lbErrorMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorMsg.Name = "lbErrorMsg";
            this.lbErrorMsg.Size = new System.Drawing.Size(15, 15);
            this.lbErrorMsg.TabIndex = 18;
            this.lbErrorMsg.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "错误提示:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "频率:";
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(523, 45);
            this.tbInterval.Margin = new System.Windows.Forms.Padding(4);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(69, 25);
            this.tbInterval.TabIndex = 15;
            this.tbInterval.Text = "50";
            // 
            // lbClientCount
            // 
            this.lbClientCount.AutoSize = true;
            this.lbClientCount.Location = new System.Drawing.Point(124, 199);
            this.lbClientCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClientCount.Name = "lbClientCount";
            this.lbClientCount.Size = new System.Drawing.Size(15, 15);
            this.lbClientCount.TabIndex = 14;
            this.lbClientCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "在线连接数:";
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(132, 259);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 49);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lbReceiveDataCount
            // 
            this.lbReceiveDataCount.AutoSize = true;
            this.lbReceiveDataCount.Location = new System.Drawing.Point(108, 162);
            this.lbReceiveDataCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReceiveDataCount.Name = "lbReceiveDataCount";
            this.lbReceiveDataCount.Size = new System.Drawing.Size(15, 15);
            this.lbReceiveDataCount.TabIndex = 10;
            this.lbReceiveDataCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "接收计数:";
            // 
            // lbSendDataCount
            // 
            this.lbSendDataCount.AutoSize = true;
            this.lbSendDataCount.Location = new System.Drawing.Point(108, 90);
            this.lbSendDataCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSendDataCount.Name = "lbSendDataCount";
            this.lbSendDataCount.Size = new System.Drawing.Size(15, 15);
            this.lbSendDataCount.TabIndex = 8;
            this.lbSendDataCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "发送次数:";
            // 
            // lbErrorCount
            // 
            this.lbErrorCount.AutoSize = true;
            this.lbErrorCount.Location = new System.Drawing.Point(108, 126);
            this.lbErrorCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorCount.Name = "lbErrorCount";
            this.lbErrorCount.Size = new System.Drawing.Size(15, 15);
            this.lbErrorCount.TabIndex = 6;
            this.lbErrorCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "错误计数:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(240, 259);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 49);
            this.btnStop.TabIndex = 21;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 444);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "压力测试工具";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbErrorCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSendDataCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbReceiveDataCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lbClientCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.Label lbErrorMsg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbConCount;
        private System.Windows.Forms.Button btnStop;
    }
}


namespace Producer.WinForm
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbQueueExchange = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBindQueue = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeclareQueueRoutingKey = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeclareExchange = new System.Windows.Forms.Button();
            this.cbDeclareExchangeType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeclareExchangeName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeclareQueue = new System.Windows.Forms.Button();
            this.txtDeclareQueueName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnPublish = new System.Windows.Forms.Button();
            this.chUseCounter = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericRepeatCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRoutingKey = new System.Windows.Forms.TextBox();
            this.txtExchangeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLblConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtLog = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.gbQueueExchange.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeatCount)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(113, 30);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(359, 20);
            this.txtConnectionString.TabIndex = 1;
            this.txtConnectionString.Text = "amqp://nergis:nergis@192.168.1.100:5672";
            this.txtConnectionString.TextChanged += new System.EventHandler(this.txtConnectionString_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(478, 28);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtConnectionString);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // gbQueueExchange
            // 
            this.gbQueueExchange.Controls.Add(this.groupBox5);
            this.gbQueueExchange.Controls.Add(this.groupBox4);
            this.gbQueueExchange.Controls.Add(this.groupBox3);
            this.gbQueueExchange.Location = new System.Drawing.Point(12, 102);
            this.gbQueueExchange.Name = "gbQueueExchange";
            this.gbQueueExchange.Size = new System.Drawing.Size(735, 255);
            this.gbQueueExchange.TabIndex = 1;
            this.gbQueueExchange.TabStop = false;
            this.gbQueueExchange.Text = "Queue / Exchange && Bind";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBindQueue);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtDeclareQueueRoutingKey);
            this.groupBox5.Location = new System.Drawing.Point(184, 157);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(328, 91);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bind Queue && Exchange";
            // 
            // btnBindQueue
            // 
            this.btnBindQueue.Location = new System.Drawing.Point(29, 50);
            this.btnBindQueue.Name = "btnBindQueue";
            this.btnBindQueue.Size = new System.Drawing.Size(291, 23);
            this.btnBindQueue.TabIndex = 4;
            this.btnBindQueue.Text = "Declare";
            this.btnBindQueue.UseVisualStyleBackColor = true;
            this.btnBindQueue.Click += new System.EventHandler(this.btnBindQueue_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Routing Key";
            // 
            // txtDeclareQueueRoutingKey
            // 
            this.txtDeclareQueueRoutingKey.Location = new System.Drawing.Point(97, 24);
            this.txtDeclareQueueRoutingKey.Name = "txtDeclareQueueRoutingKey";
            this.txtDeclareQueueRoutingKey.Size = new System.Drawing.Size(223, 20);
            this.txtDeclareQueueRoutingKey.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeclareExchange);
            this.groupBox4.Controls.Add(this.cbDeclareExchangeType);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtDeclareExchangeName);
            this.groupBox4.Location = new System.Drawing.Point(361, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 132);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Declare Exchange";
            // 
            // btnDeclareExchange
            // 
            this.btnDeclareExchange.Location = new System.Drawing.Point(82, 86);
            this.btnDeclareExchange.Name = "btnDeclareExchange";
            this.btnDeclareExchange.Size = new System.Drawing.Size(223, 23);
            this.btnDeclareExchange.TabIndex = 4;
            this.btnDeclareExchange.Text = "Declare";
            this.btnDeclareExchange.UseVisualStyleBackColor = true;
            this.btnDeclareExchange.Click += new System.EventHandler(this.btnDeclareExchange_Click);
            // 
            // cbDeclareExchangeType
            // 
            this.cbDeclareExchangeType.FormattingEnabled = true;
            this.cbDeclareExchangeType.Location = new System.Drawing.Point(82, 50);
            this.cbDeclareExchangeType.Name = "cbDeclareExchangeType";
            this.cbDeclareExchangeType.Size = new System.Drawing.Size(223, 21);
            this.cbDeclareExchangeType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // txtDeclareExchangeName
            // 
            this.txtDeclareExchangeName.Location = new System.Drawing.Point(82, 24);
            this.txtDeclareExchangeName.Name = "txtDeclareExchangeName";
            this.txtDeclareExchangeName.Size = new System.Drawing.Size(223, 20);
            this.txtDeclareExchangeName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeclareQueue);
            this.groupBox3.Controls.Add(this.txtDeclareQueueName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(19, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 132);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Declare Queue";
            // 
            // btnDeclareQueue
            // 
            this.btnDeclareQueue.Location = new System.Drawing.Point(227, 19);
            this.btnDeclareQueue.Name = "btnDeclareQueue";
            this.btnDeclareQueue.Size = new System.Drawing.Size(75, 23);
            this.btnDeclareQueue.TabIndex = 3;
            this.btnDeclareQueue.Text = "Declare";
            this.btnDeclareQueue.UseVisualStyleBackColor = true;
            this.btnDeclareQueue.Click += new System.EventHandler(this.btnDeclareQueue_Click);
            // 
            // txtDeclareQueueName
            // 
            this.txtDeclareQueueName.Location = new System.Drawing.Point(82, 48);
            this.txtDeclareQueueName.Name = "txtDeclareQueueName";
            this.txtDeclareQueueName.Size = new System.Drawing.Size(220, 20);
            this.txtDeclareQueueName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Queue Name";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnPublish);
            this.pnlMain.Controls.Add(this.chUseCounter);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.numericRepeatCount);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.txtMessage);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.txtRoutingKey);
            this.pnlMain.Controls.Add(this.txtExchangeName);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Location = new System.Drawing.Point(9, 371);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(737, 210);
            this.pnlMain.TabIndex = 2;
            // 
            // btnPublish
            // 
            this.btnPublish.BackColor = System.Drawing.Color.Transparent;
            this.btnPublish.Location = new System.Drawing.Point(446, 168);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(114, 39);
            this.btnPublish.TabIndex = 11;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = false;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // chUseCounter
            // 
            this.chUseCounter.AutoSize = true;
            this.chUseCounter.Location = new System.Drawing.Point(310, 172);
            this.chUseCounter.Name = "chUseCounter";
            this.chUseCounter.Size = new System.Drawing.Size(85, 17);
            this.chUseCounter.TabIndex = 10;
            this.chUseCounter.Text = "Use Counter";
            this.chUseCounter.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Repeat";
            // 
            // numericRepeatCount
            // 
            this.numericRepeatCount.Location = new System.Drawing.Point(153, 172);
            this.numericRepeatCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericRepeatCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericRepeatCount.Name = "numericRepeatCount";
            this.numericRepeatCount.Size = new System.Drawing.Size(120, 20);
            this.numericRepeatCount.TabIndex = 8;
            this.numericRepeatCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Location = new System.Drawing.Point(153, 79);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(445, 76);
            this.txtMessage.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Routing Key";
            // 
            // txtRoutingKey
            // 
            this.txtRoutingKey.Location = new System.Drawing.Point(244, 42);
            this.txtRoutingKey.Name = "txtRoutingKey";
            this.txtRoutingKey.Size = new System.Drawing.Size(223, 20);
            this.txtRoutingKey.TabIndex = 4;
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(244, 16);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.Size = new System.Drawing.Size(223, 20);
            this.txtExchangeName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Exchange Name/Type";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 846);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLblConnectionStatus
            // 
            this.tsLblConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLblConnectionStatus.Name = "tsLblConnectionStatus";
            this.tsLblConnectionStatus.Size = new System.Drawing.Size(229, 20);
            this.tsLblConnectionStatus.Text = "Connection State: Not Connected";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtLog.FormattingEnabled = true;
            this.txtLog.ItemHeight = 16;
            this.txtLog.Location = new System.Drawing.Point(9, 587);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(738, 228);
            this.txtLog.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 871);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.gbQueueExchange);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "RabbitMQ Producer Winform App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbQueueExchange.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeatCount)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbQueueExchange;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeclareQueue;
        private System.Windows.Forms.TextBox txtDeclareQueueName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBindQueue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeclareQueueRoutingKey;
        private System.Windows.Forms.Button btnDeclareExchange;
        private System.Windows.Forms.ComboBox cbDeclareExchangeType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeclareExchangeName;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRoutingKey;
        private System.Windows.Forms.TextBox txtExchangeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.CheckBox chUseCounter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericRepeatCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLblConnectionStatus;
        private System.Windows.Forms.ListBox txtLog;
    }
}


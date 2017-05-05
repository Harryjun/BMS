namespace Application_usart
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.button_open = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.group_voltage = new System.Windows.Forms.Panel();
            this.Btn_Volatage = new System.Windows.Forms.Button();
            this.Btn_SOC = new System.Windows.Forms.Button();
            this.Btn_SOH = new System.Windows.Forms.Button();
            this.Btn_ADD = new System.Windows.Forms.Button();
            this.group_soc = new System.Windows.Forms.Panel();
            this.group_soh = new System.Windows.Forms.Panel();
            this.group_fujia = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.Btn_DataSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Time_Now = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Statu_Battery = new System.Windows.Forms.TextBox();
            this.SOC_Sum = new System.Windows.Forms.TextBox();
            this.Current_Sum = new System.Windows.Forms.TextBox();
            this.Voltage_Sum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Temperature = new System.Windows.Forms.Button();
            this.group_temperature = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(60, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 20);
            this.comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 8192;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.post_DataReceived);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "十六进制";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(90, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "字符";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(89, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 24);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "接收方式";
            // 
            // textBox_receive
            // 
            this.textBox_receive.Location = new System.Drawing.Point(6, 20);
            this.textBox_receive.Multiline = true;
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_receive.Size = new System.Drawing.Size(237, 163);
            this.textBox_receive.TabIndex = 9;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(279, 48);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 10;
            this.button_open.Text = "打开串口";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 116);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.comboBox5.Location = new System.Drawing.Point(60, 84);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(60, 20);
            this.comboBox5.TabIndex = 16;
            this.comboBox5.Text = "无";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(18, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "奇偶位";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox3.Location = new System.Drawing.Point(183, 49);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(60, 20);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(141, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "停止位";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBox4.Location = new System.Drawing.Point(183, 20);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(60, 20);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(141, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "数据位";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_receive);
            this.groupBox2.Location = new System.Drawing.Point(14, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 189);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收数据";
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(6, 17);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(239, 61);
            this.textBox_send.TabIndex = 13;
            this.textBox_send.TextChanged += new System.EventHandler(this.textBox_send_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_send);
            this.groupBox3.Location = new System.Drawing.Point(12, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 87);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送数据";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(166, 491);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 15;
            this.button_send.Text = "发送数据";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(279, 74);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 16;
            this.button_clear.Text = "清空接收区";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // group_voltage
            // 
            this.group_voltage.AutoScroll = true;
            this.group_voltage.Location = new System.Drawing.Point(281, 142);
            this.group_voltage.Name = "group_voltage";
            this.group_voltage.Size = new System.Drawing.Size(162, 165);
            this.group_voltage.TabIndex = 17;
            // 
            // Btn_Volatage
            // 
            this.Btn_Volatage.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Volatage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Volatage.Location = new System.Drawing.Point(280, 119);
            this.Btn_Volatage.Name = "Btn_Volatage";
            this.Btn_Volatage.Size = new System.Drawing.Size(75, 23);
            this.Btn_Volatage.TabIndex = 18;
            this.Btn_Volatage.Text = "电压";
            this.Btn_Volatage.UseVisualStyleBackColor = false;
            this.Btn_Volatage.Click += new System.EventHandler(this.Btn_Volatage_Click);
            // 
            // Btn_SOC
            // 
            this.Btn_SOC.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_SOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_SOC.Location = new System.Drawing.Point(354, 119);
            this.Btn_SOC.Name = "Btn_SOC";
            this.Btn_SOC.Size = new System.Drawing.Size(75, 23);
            this.Btn_SOC.TabIndex = 19;
            this.Btn_SOC.Text = "SOC";
            this.Btn_SOC.UseVisualStyleBackColor = false;
            this.Btn_SOC.Click += new System.EventHandler(this.Btn_SOC_Click);
            // 
            // Btn_SOH
            // 
            this.Btn_SOH.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_SOH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_SOH.Location = new System.Drawing.Point(427, 119);
            this.Btn_SOH.Name = "Btn_SOH";
            this.Btn_SOH.Size = new System.Drawing.Size(75, 23);
            this.Btn_SOH.TabIndex = 20;
            this.Btn_SOH.Text = "SOH";
            this.Btn_SOH.UseVisualStyleBackColor = false;
            this.Btn_SOH.Click += new System.EventHandler(this.Btn_SOH_Click);
            // 
            // Btn_ADD
            // 
            this.Btn_ADD.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_ADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_ADD.Location = new System.Drawing.Point(562, 119);
            this.Btn_ADD.Name = "Btn_ADD";
            this.Btn_ADD.Size = new System.Drawing.Size(75, 23);
            this.Btn_ADD.TabIndex = 21;
            this.Btn_ADD.Text = "附加页";
            this.Btn_ADD.UseVisualStyleBackColor = false;
            this.Btn_ADD.Click += new System.EventHandler(this.Btn_ADD_Click);
            // 
            // group_soc
            // 
            this.group_soc.AutoScroll = true;
            this.group_soc.Location = new System.Drawing.Point(465, 176);
            this.group_soc.Name = "group_soc";
            this.group_soc.Size = new System.Drawing.Size(61, 51);
            this.group_soc.TabIndex = 18;
            this.group_soc.Visible = false;
            // 
            // group_soh
            // 
            this.group_soh.AutoScroll = true;
            this.group_soh.Location = new System.Drawing.Point(551, 151);
            this.group_soh.Name = "group_soh";
            this.group_soh.Size = new System.Drawing.Size(129, 118);
            this.group_soh.TabIndex = 19;
            this.group_soh.Visible = false;
            // 
            // group_fujia
            // 
            this.group_fujia.AutoScroll = true;
            this.group_fujia.Location = new System.Drawing.Point(697, 176);
            this.group_fujia.Name = "group_fujia";
            this.group_fujia.Size = new System.Drawing.Size(104, 72);
            this.group_fujia.TabIndex = 20;
            this.group_fujia.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(269, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(581, 560);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "单体信息显示";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(757, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "计数";
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Location = new System.Drawing.Point(804, 31);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(11, 12);
            this.Counter.TabIndex = 24;
            this.Counter.Text = "0";
            // 
            // Btn_DataSave
            // 
            this.Btn_DataSave.Location = new System.Drawing.Point(360, 74);
            this.Btn_DataSave.Name = "Btn_DataSave";
            this.Btn_DataSave.Size = new System.Drawing.Size(75, 23);
            this.Btn_DataSave.TabIndex = 25;
            this.Btn_DataSave.Text = "数据存储";
            this.Btn_DataSave.UseVisualStyleBackColor = true;
            this.Btn_DataSave.Click += new System.EventHandler(this.Btn_DataSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "当前时间";
            // 
            // Time_Now
            // 
            this.Time_Now.AutoSize = true;
            this.Time_Now.Location = new System.Drawing.Point(625, 31);
            this.Time_Now.Name = "Time_Now";
            this.Time_Now.Size = new System.Drawing.Size(11, 12);
            this.Time_Now.TabIndex = 27;
            this.Time_Now.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Statu_Battery);
            this.groupBox5.Controls.Add(this.SOC_Sum);
            this.groupBox5.Controls.Add(this.Current_Sum);
            this.groupBox5.Controls.Add(this.Voltage_Sum);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(441, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(404, 52);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "总体信息显示";
            // 
            // Statu_Battery
            // 
            this.Statu_Battery.Location = new System.Drawing.Point(337, 20);
            this.Statu_Battery.Name = "Statu_Battery";
            this.Statu_Battery.Size = new System.Drawing.Size(55, 21);
            this.Statu_Battery.TabIndex = 7;
            // 
            // SOC_Sum
            // 
            this.SOC_Sum.Location = new System.Drawing.Point(223, 20);
            this.SOC_Sum.Name = "SOC_Sum";
            this.SOC_Sum.Size = new System.Drawing.Size(55, 21);
            this.SOC_Sum.TabIndex = 6;
            // 
            // Current_Sum
            // 
            this.Current_Sum.Location = new System.Drawing.Point(140, 20);
            this.Current_Sum.Name = "Current_Sum";
            this.Current_Sum.Size = new System.Drawing.Size(55, 21);
            this.Current_Sum.TabIndex = 5;
            // 
            // Voltage_Sum
            // 
            this.Voltage_Sum.Location = new System.Drawing.Point(45, 20);
            this.Voltage_Sum.Name = "Voltage_Sum";
            this.Voltage_Sum.Size = new System.Drawing.Size(52, 21);
            this.Voltage_Sum.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "电池状态";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "SOC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "总电流";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "总电压";
            // 
            // Btn_Temperature
            // 
            this.Btn_Temperature.BackColor = System.Drawing.Color.DarkGray;
            this.Btn_Temperature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Temperature.Location = new System.Drawing.Point(500, 119);
            this.Btn_Temperature.Name = "Btn_Temperature";
            this.Btn_Temperature.Size = new System.Drawing.Size(75, 23);
            this.Btn_Temperature.TabIndex = 22;
            this.Btn_Temperature.Text = "温度";
            this.Btn_Temperature.UseVisualStyleBackColor = false;
            this.Btn_Temperature.Click += new System.EventHandler(this.Temperature_Battery_Click);
            // 
            // group_temperature
            // 
            this.group_temperature.AutoScroll = true;
            this.group_temperature.Location = new System.Drawing.Point(599, 275);
            this.group_temperature.Name = "group_temperature";
            this.group_temperature.Size = new System.Drawing.Size(104, 72);
            this.group_temperature.TabIndex = 23;
            this.group_temperature.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.数据ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 25);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 数据ToolStripMenuItem
            // 
            this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
            this.数据ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.数据ToolStripMenuItem.Text = "数据";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 674);
            this.Controls.Add(this.group_temperature);
            this.Controls.Add(this.Btn_Temperature);
            this.Controls.Add(this.Btn_ADD);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Time_Now);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Btn_DataSave);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.group_fujia);
            this.Controls.Add(this.group_soc);
            this.Controls.Add(this.group_soh);
            this.Controls.Add(this.Btn_SOH);
            this.Controls.Add(this.Btn_SOC);
            this.Controls.Add(this.Btn_Volatage);
            this.Controls.Add(this.group_voltage);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BMS数据显示PC端V1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Panel group_voltage;
        private System.Windows.Forms.Button Btn_Volatage;
        private System.Windows.Forms.Button Btn_SOC;
        private System.Windows.Forms.Button Btn_SOH;
        private System.Windows.Forms.Button Btn_ADD;
        private System.Windows.Forms.Panel group_soc;
        private System.Windows.Forms.Panel group_soh;
        private System.Windows.Forms.Panel group_fujia;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Button Btn_DataSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Time_Now;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Statu_Battery;
        private System.Windows.Forms.TextBox SOC_Sum;
        private System.Windows.Forms.TextBox Current_Sum;
        private System.Windows.Forms.TextBox Voltage_Sum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel group_temperature;
        private System.Windows.Forms.Button Btn_Temperature;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
    }
}


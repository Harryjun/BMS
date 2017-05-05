using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace Application_usart
{
    public partial class Form1 : Form
    {
        public const int Width_Label = 47;
        public const int Height_Label = 12;
        public const int Width_Text = 50;
        public const int Height_Text = 20;
        int COM_MAX = 10;//COM口号最大值
        int State_Show = 0;
        int Button_on = 1;
        int temp1 = 0;
        /*声明数据数组*/
        /*1电池电压数组2电池SOC数组3电池SOH数组*/
        TextBox[] Voltage_Battery = new TextBox[5 * 20];
        TextBox[] Soc_Battery = new TextBox[5 * 20];
        TextBox[] Soh_Battery = new TextBox[5 * 20];
        TextBox[] Fj_Battery = new TextBox[5 * 20];
        TextBox[] Temperature_Battery = new TextBox[5 * 20];

        /*数据帧协议*/
        Byte Header_data = 0x88;//数据帧头
        byte[] Flag_VoltageData = {0x0A,0x1D};
        byte[] Flag_SOCData = { 0x1F, 0x2E };
        byte[] Flag_SOHData = { 0x33, 0x42 };
        byte[] Flag_TemperatureData = { 0x43, 0x43 };//待添加
        byte[] Flag_Sum = { 0x03, 0x07, 0x08, 0x09 };
        /*动态变量*/
        int Length_Data = 0;

        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            PAGE_Init();
            comboBox1.Text = "COM1";
            for(i=1;i<COM_MAX;i++)
            {
                comboBox1.Items.Add("COM" + i.ToString());
            }
            comboBox2.Text = "115200";
           // for(int i = 0;i<)
          //  serialPort1.DataReceived += new SerialDataReceivedEventHandler(post_DataReceived);
        }


        private void post_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(50); //延时
           /* 
            if (!radioButton1.Checked)
            {
                string str = serialPort1.ReadExisting();//字符串方式读
                textBox_receive.AppendText(str);

            }
            else
            {
                
                byte data;
                data = (byte)serialPort1.ReadByte();
                string str = Convert.ToString(data, 16).ToUpper();//
                textBox_receive.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + "  ");
                
                Byte[] receivedData = new Byte[serialPort1.BytesToRead];        //创建接收字节数组
                serialPort1.Read(receivedData, 0, receivedData.Length);         //读取数据
                textBox_receive.AppendText(receivedData.ToString());
            }*/
            try//尝试协议接收数据
            {
                Byte[] receivedData = new Byte[serialPort1.BytesToRead];        //创建接收字节数组
                serialPort1.Read(receivedData, 0, receivedData.Length);         //读取数据
                //循环遍历接收到的数组
                for (int i = 0; i < receivedData.Length-4; i++)
                {
                    if (receivedData[i] == Header_data)
                    {//数据协议   帧头
                        if ((receivedData[i + 1] + receivedData[i + 2] + receivedData[i + 3]) == receivedData[i+4])
                        {//和校验
                            if (receivedData[i + 1] >= Flag_VoltageData[0] && receivedData[i + 1] <= Flag_VoltageData[1])
                            {//电压数据显示
                                Voltage_Battery[receivedData[i + 1] - Flag_VoltageData[0]].Text = (receivedData[i + 2] * 16 + receivedData[i + 3]).ToString() + "mv";//.ToString("X2");
                                i = i + 4;
                             //   textBox_receive.AppendText(i.ToString());//测试用语句
                            }
                            else if (receivedData[i + 1] >= Flag_SOCData[0] && receivedData[i + 1] <= Flag_SOCData[1])
                            {//SOC数据显示
                                Soc_Battery[receivedData[i + 1] - Flag_SOCData[0]].Text = (receivedData[i + 2] * 16 + receivedData[i + 3]).ToString() + "ma";
                                i = i + 4;
                             //   textBox_receive.AppendText(i.ToString());//测试用语句
                            }
                            else if (receivedData[i + 1] >= Flag_SOHData[0] && receivedData[i + 1] <= Flag_SOHData[1])
                            {//SOH数据显示
                                Soh_Battery[receivedData[i + 1] - Flag_SOHData[0]].Text = (receivedData[i + 2] * 16 + receivedData[i + 3]).ToString() + "mv";
                                i = i + 4;
                            //    textBox_receive.AppendText(i.ToString());//测试用语句
                            }
                            else if (receivedData[i + 1] >= Flag_TemperatureData[0] && receivedData[i + 1] <= Flag_TemperatureData[1])
                            {//Temperature数据显示
                                Temperature_Battery[receivedData[i + 1] - Flag_TemperatureData[0]].Text = (receivedData[i + 2] * 16 + receivedData[i + 3]).ToString() + "mv";
                                i = i + 4;
                                //    textBox_receive.AppendText(i.ToString());//测试用语句
                            }
                            //总电池显示显示
                            else if(receivedData[i + 1] == Flag_Sum[0])
                            {//充电状态
                                if (receivedData[i + 2] == 0x01)
                                {
                                    Statu_Battery.Text = "静置状态";
                                    i = i + 4;
                                }
                                else if(receivedData[i + 2] == 0x02) 
                                {
                                    Statu_Battery.Text = "放电状态";
                                    i = i + 4;
                                }
                                else if(receivedData[i + 2] == 0x04) 
                                {
                                    Statu_Battery.Text = "充电状态";
                                    i = i + 4;
                                }
                            }
                            else if(receivedData[i + 1] == Flag_Sum[1])
                            {//总电压显示

                                Voltage_Sum.Text = (receivedData[i + 2] * 16 + receivedData[i + 3]).ToString() + "mv";
                                i = i + 4;
                            }
                            else if (receivedData[i + 1] == Flag_Sum[2])
                            {//总电流显示

                                Current_Sum.Text = (receivedData[i + 2] * 16 + receivedData[i + 3]).ToString() + "mv";
                                i = i + 4;
                            }
                            else if (receivedData[i + 1] == Flag_Sum[3])
                            {//总SOC显示

                                SOC_Sum.Text = (receivedData[i + 2] * 16 + receivedData[i + 3]).ToString() + "mv";
                                i = i + 4;
                            }


                        }
                       
                    }
                    else
                    {
                       // textBox1.AppendText(receivedData[i].ToString("X2") + " ");
                       // strRcv += receivedData[i].ToString("X2") + " ";
                    }
                }
                Length_Data = Length_Data + receivedData.Length;//记录数据量
                Counter.Text = Length_Data.ToString();
//                int count = strRcv.Length / 48;                           // 记录数据的个数
         //       for (int j = 0; j < count; j++)
                {
                    /// 获取每条记录
     //               string buf1 = strRcv.Substring(j * 48, 48);
                    /// 添加字符串数据到数据库
       //             DataList.Add(buf1);
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "出错提示");
            //    textBox1.Text = "";
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_open_Click(object sender, EventArgs e)
        {
           // if(Button_on == 1)
            if (!serialPort1.IsOpen)//如果串口是开
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text, 10);
                float f = Convert.ToSingle(comboBox3.Text.Trim());
                if (f == 0)//设置停止位
                    serialPort1.StopBits = StopBits.None;
                else if (f == 1.5)
                    serialPort1.StopBits = StopBits.OnePointFive;
                else if (f == 1)
                    serialPort1.StopBits = StopBits.One;
                else if (f == 2)
                    serialPort1.StopBits = StopBits.Two;
                else
                    serialPort1.StopBits = StopBits.One;
                //设置数据位
                serialPort1.DataBits = Convert.ToInt32(comboBox4.Text.Trim());
                //设置奇偶校验位
                string s = comboBox5.Text.Trim();
                if (s.CompareTo("无") == 0)
                    serialPort1.Parity = Parity.None;
                else if (s.CompareTo("奇校验") == 0)
                    serialPort1.Parity = Parity.Odd;
                else if (s.CompareTo("偶校验") == 0)
                    serialPort1.Parity = Parity.Even;
                else
                    serialPort1.Parity = Parity.None;
                try
                {
                    serialPort1.Open();     //打开串口
                    button_open.Text = "关闭串口";
                    comboBox1.Enabled = false;//关闭使能
                    comboBox2.Enabled = false;
                    comboBox3.Enabled = false;
                    comboBox4.Enabled = false;
                    comboBox5.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("串口打开失败！");
                }
            }
            else//如果串口是打开的则将其关闭
            {
                serialPort1.Close();
                button_open.Text = "打开串口";
                comboBox1.Enabled = true;//使能配置
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox5.Enabled = true;
            }           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void button_send_Click(object sender, EventArgs e)
        {//发送数据
            if(serialPort1.IsOpen)
            {//如果串口开启
                if (textBox_send.Text.Trim() != "")//如果框内不为空则
                {
                    serialPort1.Write(textBox_send.Text.Trim());//写数据
                }
                else
                {
                    MessageBox.Show("发送框没有数据");
                }
            }
            else
            {
                MessageBox.Show("串口未打开");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_receive.Clear();//清空接收框
            Length_Data = 0;//清空计数
            Counter.Text = Length_Data.ToString();
        }

        private void Btn_Volatage_Click(object sender, EventArgs e)
        {//电压显示
            State_Show = 0;
            group_voltage.Visible = true;
            group_soc.Visible = false;
            group_soh.Visible = false;
            group_fujia.Visible = false;
            group_temperature.Visible = false;
        }

        private void Btn_SOC_Click(object sender, EventArgs e)
        {//SOC显示
            State_Show = 1;
            group_voltage.Visible = false;
            group_soc.Visible = true;
            group_soh.Visible = false;
            group_fujia.Visible = false;
            group_temperature.Visible = false;
            
            //this.group_soc.BringToFront();
        }

        private void Btn_SOH_Click(object sender, EventArgs e)
        {
            State_Show = 2;
            group_voltage.Visible = false;
            group_soc.Visible = false;
            group_soh.Visible = true;
            group_fujia.Visible = false;
            group_temperature.Visible = false;
            
        }

        private void Btn_ADD_Click(object sender, EventArgs e)
        {
            State_Show = 3;
            group_voltage.Visible = false;
            group_soc.Visible = false;
            group_soh.Visible = false ;
            group_fujia.Visible = true;
            group_temperature.Visible = false;
        }
        public void PAGE_Init()
        {

            //声明暂存变量
            int i=0,j=0;
            //1电池组电压容器创建
            //添加文本框与字符
            for (i = 0; i < 5;i++ )
            {
                for (j=0;j<20;j++)
                {
                    //创建标签与显示窗体
                    Label Label_Voltage = new Label();

                    //设置标签属性
                    Label_Voltage.Name = "Label_Volatage" + (i + j * 5 + 1).ToString();
                    Label_Voltage.Text = "电池" + (i + j * 5 + 1).ToString();
                    Label_Voltage.Width = Width_Label;
                    Label_Voltage.Height = Height_Label;

                    //位置确定
                    Label_Voltage.Location = new Point(15 + i * (Width_Label + Width_Text + 6), 15 + j * (12 + Height_Label));

                    group_voltage.Controls.Add(Label_Voltage);//将字符添加到容器1中
                    //电池组电压数组设置
                    Voltage_Battery[i + j * 5] = new TextBox();//注意！！！先声明对象
                    Voltage_Battery[i + j * 5].Name = "Voltage_Battery" + i.ToString();
                    Voltage_Battery[i + j * 5 ].Text = (i + j * 5 + 1).ToString();
                    Voltage_Battery[i + j * 5].Width = Width_Text;
                    Voltage_Battery[i + j * 5].Height = Height_Text;
                    Voltage_Battery[i + j * 5 ].Location = new Point(67 + i * (Width_Label + Width_Text + 6), 11 + j * (4 + Height_Text));
                    group_voltage.Controls.Add(Voltage_Battery[i + j * 5]);//将电压组添加到容器1中
                }
            }
           //设置宽度
           this.group_voltage.Width = 552;
           this.group_voltage.Height = 500;
            
            //SOC容器搭建
            //添加文本框与字符
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 20; j++)
                {
                    //创建标签
                    Label Label_Soc = new Label();

                    //设置标签属性
                    Label_Soc.Name = "Label_SOC" + (i + j * 5 + 1).ToString();
                    Label_Soc.Text = "SOC" + (i + j * 5 + 1).ToString();
                    Label_Soc.Width = Width_Label;
                    Label_Soc.Height = Height_Label;
                    //设置文本框数组属性
                    Soc_Battery[i + j * 5] = new TextBox();//注意！！！先声明对象
                    Soc_Battery[i + j * 5].Name = "SOC_Battery" + (i + j * 5 + 1).ToString();
                    Soc_Battery[i + j * 5].Text = (i + j * 5 + 1).ToString();
                    Soc_Battery[i + j * 5].Width = Width_Text;
                    Soc_Battery[i + j * 5].Height = Height_Text;

                    //位置确定
                    Label_Soc.Location = new Point(15 + i * (Width_Label + Width_Text + 6), 15 + j * (12 + Height_Label));
                    group_soc.Controls.Add(Label_Soc);//将字符添加到容器2中

                    Soc_Battery[i + j * 5].Location = new Point(67 + i * (Width_Label + Width_Text + 6), 11 + j * (4 + Height_Text));
                    group_soc.Controls.Add(Soc_Battery[i + j * 5]);//将SOC添加到容器2中
                }
            }
            //设置宽度位置
            this.group_soc.Width = group_voltage.Width;
            this.group_soc.Height = group_voltage.Height;
            group_soc.Location = group_voltage.Location;

            //SOH容器搭建
            //添加文本框与字符
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 20; j++)
                {
                    //创建标签与显示窗体
                    Label Label_Soh = new Label();
    

                    //设置标签属性
                    Label_Soh.Name = "Label_SOH" + (i + j * 5 + 1).ToString();
                    Label_Soh.Text = "SOH" + (i + j * 5 + 1).ToString();
                    Label_Soh.Width = Width_Label;
                    Label_Soh.Height = Height_Label;

                    Soh_Battery[i + j * 5] = new TextBox();//注意！！！先声明对象
                    //设置文本框属性
                    Soh_Battery[i + j * 5].Name = "SOH_Battery" + (i + j * 5 + 1).ToString();
                    Soh_Battery[i + j * 5].Text = (i + j * 5 + 1).ToString();
                    Soh_Battery[i + j * 5].Width = Width_Text;
                    Soh_Battery[i + j * 5].Height = Height_Text;

                    //位置确定
                    Label_Soh.Location = new Point(15 + i * (Width_Label + Width_Text + 6), 15 + j * (12 + Height_Label));
                    group_soh.Controls.Add(Label_Soh);//将字符添加到容器3中

                    Soh_Battery[i + j * 5].Location = new Point(67 + i * (Width_Label + Width_Text + 6), 11 + j * (4 + Height_Text));
                    group_soh.Controls.Add(Soh_Battery[i + j * 5]);//将SOH添加到容器3中
                }
            }
            //设置宽度位置
            this.group_soh.Width = group_voltage.Width;
            this.group_soh.Height = group_voltage.Height;
            group_soh.Location = group_voltage.Location;


            //附加页面容器搭建
            //添加文本框与字符
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 20; j++)
                {
                    //创建标签与显示窗体
                    Label Label_Fj = new Label();

                    //设置标签属性
                    Label_Fj.Name = "Label_Fj" + (i + j * 5 + 1).ToString();
                    Label_Fj.Text = "附加" + (i + j * 5 + 1).ToString();
                    Label_Fj.Width = Width_Label;
                    Label_Fj.Height = Height_Label;

                    Fj_Battery[i + j * 5] = new TextBox();//注意！！！先声明对象
                    //设置文本框属性
                    Fj_Battery[i + j * 5].Name = "Fj_Battery" + (i + j * 5 + 1).ToString();
                    Fj_Battery[i + j * 5].Text = (i + j * 5 + 1).ToString();
                    Fj_Battery[i + j * 5].Width = Width_Text;
                    Fj_Battery[i + j * 5].Height = Height_Text;

                    //位置确定
                    Label_Fj.Location = new Point(15 + i * (Width_Label + Width_Text + 6), 15 + j * (12 + Height_Label));
                    group_fujia.Controls.Add(Label_Fj);//将字符添加到容器4中

                    Fj_Battery[i + j * 5].Location = new Point(67 + i * (Width_Label + Width_Text + 6), 11 + j * (4 + Height_Text));
                    group_fujia.Controls.Add(Fj_Battery[i + j * 5]);//将SOC添加到容器4中
                }
            }
            //设置宽度位置
            this.group_fujia.Width = group_voltage.Width;
            this.group_fujia.Height = group_voltage.Height;
            group_fujia.Location = group_voltage.Location;

            //温度页面容器搭建
            //添加文本框与字符
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 20; j++)
                {
                    //创建标签与显示窗体
                    Label Label_Temperature = new Label();

                    //设置标签属性
                    Label_Temperature.Name = "Label_Temperature" + (i + j * 5 + 1).ToString();
                    Label_Temperature.Text = "温度" + (i + j * 5 + 1).ToString();
                    Label_Temperature.Width = Width_Label;
                    Label_Temperature.Height = Height_Label;

                    Temperature_Battery[i + j * 5] = new TextBox();//注意！！！先声明对象
                    //设置文本框属性
                    Temperature_Battery[i + j * 5].Name = "Temperature_Battery" + (i + j * 5 + 1).ToString();
                    Temperature_Battery[i + j * 5].Text = (i + j * 5 + 1).ToString();
                    Temperature_Battery[i + j * 5].Width = Width_Text;
                    Temperature_Battery[i + j * 5].Height = Height_Text;

                    //位置确定
                    Label_Temperature.Location = new Point(15 + i * (Width_Label + Width_Text + 6), 15 + j * (12 + Height_Label));
                    group_temperature.Controls.Add(Label_Temperature);//将字符添加到容器4中

                    Temperature_Battery[i + j * 5].Location = new Point(67 + i * (Width_Label + Width_Text + 6), 11 + j * (4 + Height_Text));
                    group_temperature.Controls.Add(Temperature_Battery[i + j * 5]);//将SOC添加到容器4中
                }
            }
            //设置宽度位置
            this.group_temperature.Width = group_voltage.Width;
            this.group_temperature.Height = group_voltage.Height;
            group_temperature.Location = group_voltage.Location;

        /*    foreach (Control C in group_voltage.Controls)
            {

                if (C.Name == "Voltage_Battery10")
                    C.Text = "1";
            } */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {//定时器1s
            DateTime dt = DateTime.Now;
           
            Time_Now.Text = dt.ToString();
      /*      for(int i = 0;i < 100; i++)
            {
                Voltage_Battery[i].Text = temp1.ToString();
            }*/
            //Voltage_Battery[i].Text = temp1.ToString();
            temp1++;
         /*   Control C = ;//声明一个控件
            for(int i = 0;i < 100;i++)
            {
                C.Name = "Voltage_Battery" + i.ToString();
                C.Text = temp1.ToString();
                temp1++;
            }*/
          //  (Controls.FindControl("TextBox的ID") as TextBox).Text = "1";
          //  (Controls.Find("Voltage_Battery10") as TextBox).Text = "1";
        }

        private void textBox_send_TextChanged(object sender, EventArgs e)
        {
            State_Show = 4;
            group_voltage.Visible = false;
            group_soc.Visible = false;
            group_soh.Visible = false;
            group_fujia.Visible = false;
            group_temperature.Visible = true;
        }
        /*文件对话框*/
        private string ShowSaveFileDialog()
        {
            string localFilePath = "";// fileNameExt, newFileName, FilePath; 
            SaveFileDialog sfd = new SaveFileDialog();//保存文件窗口
            //设置文件类型 
            sfd.Filter = "Excel文件(*.xlsx)|*.xlsx";//保存类型为EXCEL
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString(); //获得文件路径 
                //string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径

                //获取文件路径，不带文件名 
                //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));

            }
            return localFilePath;
        }

        private void Btn_DataSave_Click(object sender, EventArgs e)
        {//数据存储
            /*******************数据导入Excel**********************/
            string fileName = ShowSaveFileDialog();         //文件的保存路径和文件名
            try
            {
                // 创建Excel文档
                Microsoft.Office.Interop.Excel.Application ExcelApp
                    = new Microsoft.Office.Interop.Excel.Application();
                //创建EXCEL文档
                Microsoft.Office.Interop.Excel.Workbook ExcelDoc = ExcelApp.Workbooks.Add(Type.Missing);
                // 创建一个EXCEL页

                Microsoft.Office.Interop.Excel.Worksheet xlSheet = ExcelDoc.Worksheets.Add(Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing);
                ExcelApp.DisplayAlerts = false;

                // 单元格下标是从[1，1]开始的
                xlSheet.Cells[1, 1] = "序号";
                xlSheet.Cells[1, 2] = "电压";
                xlSheet.Cells[1, 3] = "SOC";
                xlSheet.Cells[1, 4] = "SOH";
                xlSheet.Cells[1, 5] = "温度";
                //遍历存数据
                for (int i = 0; i < 100; i++)
                {
                    xlSheet.Cells[i + 2, 1] = "电池" + i.ToString();
                }
                for (int i = 0; i < 100;i++ )
                {
                    xlSheet.Cells[i + 2, 2] = Voltage_Battery[i].Text;
                }
                for (int i = 0; i < 100; i++)
                {
                    xlSheet.Cells[i + 2, 3] = Soc_Battery[i].Text;
                }
                for (int i = 0; i < 100; i++)
                {
                    xlSheet.Cells[i + 2, 4] = Soh_Battery[i].Text;
                }

                // 文件保存完毕输出信息//将此页保存到我们新建的文档中
                xlSheet.SaveAs(fileName);
                //释放EXCEL资源
                ExcelDoc.Close(Type.Missing, fileName, Type.Missing);
                ExcelApp.Quit();
                MessageBox.Show("数据保存成功！");
            }
            catch
            {
                MessageBox.Show("数据保存失败！");
            }      
        }

        private void Temperature_Battery_Click(object sender, EventArgs e)
        {
            State_Show = 4;
            group_voltage.Visible = false;
            group_soc.Visible = false;
            group_soh.Visible = false;
            group_fujia.Visible = false;
            group_temperature.Visible = true;
        }
    }
}

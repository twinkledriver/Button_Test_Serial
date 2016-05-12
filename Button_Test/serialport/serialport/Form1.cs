using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Timers;
using System.Threading;



namespace serialport
{
	public partial class FormTestSerialPort : Form
	{
		private SerialPort comm = new SerialPort();
		private StringBuilder builder = new StringBuilder();
		private long receive_count = 0;
		private long send_count = 0;

		
		public FormTestSerialPort()
		{
			InitializeComponent();
			
		}

		private void FormTestSerialPort_Load(object sender, EventArgs e)
		{
			//获取串口列表
			string[] ports = SerialPort.GetPortNames();
			Array.Sort(ports);
			if(ports.Length!=0)
			comboPortNme.Text = ports[0];
			comboBaudrate.Text = "9600";
			comboPortNme.Items.AddRange(ports);
			comboPortNme.SelectedIndex = comboPortNme.Items.Count > 0 ? 0 : -1;
			comboBaudrate.SelectedIndex = comboBaudrate.Items.IndexOf("9600");
			//初始化SerialPort对象
			comm.NewLine = "/r/n";
			comm.RtsEnable = true;
			comm.DataReceived += comm_DataReceived;
			this.buttonOpenport.Text = comm.IsOpen ? "关闭端口" : "打开端口";

            if (comm.IsOpen)
            {

                //checkBox_Self_CheckedChanged(null, null);
            }


		  //  this.buttonSend.Enabled = comm.IsOpen;
		}
		void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			//读取缓冲区数据
			int n = comm.BytesToRead;
			byte[] buf = new byte[n];
			receive_count += n;
			comm.Read(buf, 0, n);
			builder.Remove(0, builder.Length);
			//同步UI
			this.BeginInvoke((EventHandler)(delegate
			{
				
				//处理16进制显示
				if (checkBoxRHex.Checked)
				{
					foreach (byte b in buf)
					{
						builder.Append(b.ToString("X2") + " ");
					}
				}
				//处理ASCII显示
				else
				{
					builder.Append(Encoding.ASCII.GetString(buf));
				}

				if (checkButton.Checked)
				{
					CheckButtonFunc();
				}



				//将接收到的数据追加到文本框末端，并将文本框滚动到末端
				this.ContentBox.AppendText(builder.ToString());
				//修改接收计数
				this.labelReceiveCount.Text = "接收计数" + receive_count.ToString();
			}));
			comm.Write(new byte[] { 0xFF, 0xFF, 0x04, 0x01, 0x01, 0x00, 0x00, 0xF9 }, 0, 8);
		}


		private void buttonOpenPort_Click(object sender, EventArgs e)
		{
			if (comboPortNme.Text.Length == 0)
			{
				MessageBox.Show("请输入正确的串口编号！");
				return;
			}
			if (comm.IsOpen)
			{
				comm.Close();
			}
			else
			{
				comm.PortName = comboPortNme.Text;
				try
				{
					comm.BaudRate = int.Parse(comboBaudrate.Text);
				}
				catch (Exception ex)
				{
					MessageBox.Show("波特率输入不正确，将使用默认波特率："+comm.BaudRate+"!");
					comboBaudrate.Text = comm.BaudRate.ToString();
				}
				try
				{
					comm.Open();
				}
				catch (Exception ex)
				{ 
					//处理并返回异常
					comm = new SerialPort();
					MessageBox.Show(ex.Message);
				}
			}
			this.buttonOpenport.Text =comm.IsOpen? "关闭端口":"打开端口";
		  //  this.buttonSend.Enabled = comm.IsOpen;
		}
		//动态获取自动换行复选框状态
		private void ContentBox_TextChanged(object sender, EventArgs e)
		{
			this.ContentBox.WordWrap = checkBoxAN.Checked;
		}

		private void buttonSend_Click(object sender, EventArgs e)
		{
			//记录发送字节数
			//int n = 0;
			//16进制发送
			//if (checkBoxSHex.Checked)
			//{
			//   // MatchCollection mc = Regex.Matches(SendBox.Text, @"(?i)[/da-f]{2}");
			//    List<byte> buf = new List<byte>();
			//    //foreach (Match m in mc)
			//    //{
			//    //    buf.Add(byte.Parse(m.Value));
			//    //}
			//    //转换为数组之后发送
			//    comm.Write(buf.ToArray(), 0, buf.Count);
			//    //记录发送的字节数
			//    n = buf.Count;

			//}
			//else
			//{
			//    //if(checkBoxSN.Checked)
			//    //{
			//    //    comm.WriteLine(SendBox.Text);
			//    //    n=SendBox.Text.Length+2;
			//    //}
			//    //else
			//    //{
			//      //  comm.Write(SendBox.Text);
			//      //  n=SendBox.Text.Length;
			//    //}
			//}
			//send_count+=n;
			//lableSendCount.Text="发送计数："+send_count.ToString();
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			//复位接收和发送字节数并更新界面
			this.ContentBox.Clear();
			send_count = receive_count = 0;
			labelReceiveCount.Text = "接收计数：0";
		   // lableSendCount.Text = "发送计数：0";
		}

	  


		private void comboPortNme_Click(object sender, EventArgs e)
		{
			string[] ports = SerialPort.GetPortNames();
			Array.Sort(ports);
			comboPortNme.Items.Clear();
			comboPortNme.Items.AddRange(ports);
		}

		private void CheckButtonFunc()
		{

			String aa = builder.ToString();
			aa = aa.Replace(" ", "");


            try
            {
                aa = aa.Substring(aa.Length - 16, 6);
            }
            catch 
            {
                return;
            }
			


			String btn1 = "010000";
			String btn2 = "020000";
			String btn3 = "040000";
			String btn4 = "080000";
			String btn5 = "100000";
			String btn6 = "200000";
			String btn7 = "400000";
			String btn8 = "800000";
			String btn9 = "000100";
			String btn10 = "000200";
			String btn11 = "000400";
			String btn12 = "000800";
			String btn13 = "001000";
			String btn14 = "002000";
			String btn15 = "004000";
			String btn16 = "008000";
			String btn17 = "000001";
			String btn18 = "000002";
			String btn19 = "000004";
			String btn20 = "000008";


			if (String.Compare(aa, btn1) == 0)
			{
				button1.BackColor = Color.Red;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;

			}
			if (String.Compare(aa, btn2) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Red;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}

			if (String.Compare(aa, btn3) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Red;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}

			if (String.Compare(aa, btn4) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Red;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn5) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Red;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn6) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Red;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn7) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Red;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn8) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Red;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn9) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Red;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn10) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Red;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn11) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Red;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn12) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Red;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn13) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Red;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn14) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor =  Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Red;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn15) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Red;
				button16.BackColor = Color.Transparent; 
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn16) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Red;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn17) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Red; 
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn18) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor =  Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Red;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn19) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Red; 
				button20.BackColor = Color.Transparent;
			}


			if (String.Compare(aa, btn20) == 0)
			{
				button1.BackColor = Color.Transparent;
				button2.BackColor = Color.Transparent;
				button3.BackColor = Color.Transparent;
				button4.BackColor = Color.Transparent;
				button5.BackColor = Color.Transparent;
				button6.BackColor = Color.Transparent;
				button7.BackColor = Color.Transparent;
				button8.BackColor = Color.Transparent;
				button9.BackColor = Color.Transparent;
				button10.BackColor = Color.Transparent;
				button11.BackColor = Color.Transparent;
				button12.BackColor = Color.Transparent;
				button13.BackColor = Color.Transparent;
				button14.BackColor = Color.Transparent;
				button15.BackColor = Color.Transparent;
				button16.BackColor = Color.Transparent;
				button17.BackColor = Color.Transparent;
				button18.BackColor = Color.Transparent;
				button19.BackColor = Color.Transparent;
				button20.BackColor = Color.Red; 
			}





		}

	
		private void groupDataReceived_Enter(object sender, EventArgs e)
		{

		}

		private void button_TestClean_Click(object sender, EventArgs e)
		{
			button1.BackColor = Color.Transparent;
			button2.BackColor = Color.Transparent;
			button3.BackColor = Color.Transparent;
			button4.BackColor = Color.Transparent;
			button5.BackColor = Color.Transparent;
			button6.BackColor = Color.Transparent;
			button7.BackColor = Color.Transparent;
			button8.BackColor = Color.Transparent;
			button9.BackColor = Color.Transparent;
			button10.BackColor = Color.Transparent;
			button11.BackColor = Color.Transparent;
			button12.BackColor = Color.Transparent;
			button13.BackColor = Color.Transparent;
			button14.BackColor = Color.Transparent;
			button15.BackColor = Color.Transparent;
			button16.BackColor = Color.Transparent;
			button17.BackColor = Color.Transparent;
			button18.BackColor = Color.Transparent;
			button19.BackColor = Color.Transparent;
			button20.BackColor = Color.Transparent;
		}

		private void selfcheck_Click(object sender, EventArgs e)
		{
			String Test_SelfCheck = "AA550700000107";

			MatchCollection mc = Regex.Matches(Test_SelfCheck, @"(?i)[\da-f]{2}");
			List<byte> buf = new List<byte>();
			foreach (Match m in mc)
			{
			  int kk=Convert.ToByte(m.Value, 16);
			  buf.Add(byte.Parse(kk.ToString()));
			}
			
            ////转换为数组之后发送
            try
            {
                comm.Write(buf.ToArray(), 0, buf.Count);
            }
            catch {
                return;
            }
			
		}

		private void day_check_Click(object sender, EventArgs e)
		{

			String Test_SelfCheck = "AA5508000003000A";

			MatchCollection mc = Regex.Matches(Test_SelfCheck, @"(?i)[\da-f]{2}");
			List<byte> buf = new List<byte>();
			foreach (Match m in mc)
			{
				int kk = Convert.ToByte(m.Value, 16);
				buf.Add(byte.Parse(kk.ToString()));
			}
			////转换为数组之后发送
			comm.Write(buf.ToArray(), 0, buf.Count);
		}

		private void night_check_Click(object sender, EventArgs e)
		{

			String Test_SelfCheck = "AA5508000003010B";

			MatchCollection mc = Regex.Matches(Test_SelfCheck, @"(?i)[\da-f]{2}");
			List<byte> buf = new List<byte>();
			foreach (Match m in mc)
			{
				int kk = Convert.ToByte(m.Value, 16);
				buf.Add(byte.Parse(kk.ToString()));
			}
			////转换为数组之后发送
			comm.Write(buf.ToArray(), 0, buf.Count);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
            
                selfcheck_Click(null, null);
       
		}


        private void checkBox_Self_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_Self.Checked)
            {
                 timer1.Enabled = true;
            }
            else 
            {
                timer1.Enabled = false;
            }
        }

		
		   
	






	   

	








	}
}

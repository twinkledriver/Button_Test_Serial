namespace serialport
{
    partial class FormTestSerialPort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestSerialPort));
            this.buttonOpenport = new System.Windows.Forms.Button();
            this.ContentBox = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboPortNme = new System.Windows.Forms.ComboBox();
            this.comboBaudrate = new System.Windows.Forms.ComboBox();
            this.groupDataReceived = new System.Windows.Forms.GroupBox();
            this.labelReceiveCount = new System.Windows.Forms.Label();
            this.checkBoxAN = new System.Windows.Forms.CheckBox();
            this.checkBoxRHex = new System.Windows.Forms.CheckBox();
            this.labelPortNME = new System.Windows.Forms.Label();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.CheckBox();
            this.button_TestClean = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.selfcheck = new System.Windows.Forms.Button();
            this.day_check = new System.Windows.Forms.Button();
            this.night_check = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox_Self = new System.Windows.Forms.CheckBox();
            this.groupDataReceived.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenport
            // 
            this.buttonOpenport.Location = new System.Drawing.Point(123, 129);
            this.buttonOpenport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenport.Name = "buttonOpenport";
            this.buttonOpenport.Size = new System.Drawing.Size(85, 31);
            this.buttonOpenport.TabIndex = 0;
            this.buttonOpenport.Text = "打开串口";
            this.buttonOpenport.UseVisualStyleBackColor = true;
            this.buttonOpenport.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(26, 56);
            this.ContentBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContentBox.Multiline = true;
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.ReadOnly = true;
            this.ContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentBox.Size = new System.Drawing.Size(382, 247);
            this.ContentBox.TabIndex = 1;
            this.ContentBox.TextChanged += new System.EventHandler(this.ContentBox_TextChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(220, 129);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(91, 31);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "清空数据";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboPortNme
            // 
            this.comboPortNme.FormattingEnabled = true;
            this.comboPortNme.Location = new System.Drawing.Point(208, 99);
            this.comboPortNme.Margin = new System.Windows.Forms.Padding(4);
            this.comboPortNme.Name = "comboPortNme";
            this.comboPortNme.Size = new System.Drawing.Size(103, 24);
            this.comboPortNme.TabIndex = 4;
            this.comboPortNme.Click += new System.EventHandler(this.comboPortNme_Click);
            // 
            // comboBaudrate
            // 
            this.comboBaudrate.AutoCompleteCustomSource.AddRange(new string[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBaudrate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBaudrate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBaudrate.FormatString = "N0";
            this.comboBaudrate.FormattingEnabled = true;
            this.comboBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBaudrate.Location = new System.Drawing.Point(418, 100);
            this.comboBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(100, 24);
            this.comboBaudrate.TabIndex = 5;
            this.comboBaudrate.Text = "9600";
            // 
            // groupDataReceived
            // 
            this.groupDataReceived.Controls.Add(this.labelReceiveCount);
            this.groupDataReceived.Controls.Add(this.checkBoxAN);
            this.groupDataReceived.Controls.Add(this.checkBoxRHex);
            this.groupDataReceived.Controls.Add(this.ContentBox);
            this.groupDataReceived.Location = new System.Drawing.Point(120, 191);
            this.groupDataReceived.Margin = new System.Windows.Forms.Padding(4);
            this.groupDataReceived.Name = "groupDataReceived";
            this.groupDataReceived.Padding = new System.Windows.Forms.Padding(4);
            this.groupDataReceived.Size = new System.Drawing.Size(427, 311);
            this.groupDataReceived.TabIndex = 6;
            this.groupDataReceived.TabStop = false;
            this.groupDataReceived.Text = "收到的数据   ";
            // 
            // labelReceiveCount
            // 
            this.labelReceiveCount.AutoSize = true;
            this.labelReceiveCount.Location = new System.Drawing.Point(303, 27);
            this.labelReceiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReceiveCount.Name = "labelReceiveCount";
            this.labelReceiveCount.Size = new System.Drawing.Size(96, 16);
            this.labelReceiveCount.TabIndex = 9;
            this.labelReceiveCount.Text = "接收计数：0";
            // 
            // checkBoxAN
            // 
            this.checkBoxAN.AutoSize = true;
            this.checkBoxAN.Checked = true;
            this.checkBoxAN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAN.Location = new System.Drawing.Point(117, 24);
            this.checkBoxAN.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAN.Name = "checkBoxAN";
            this.checkBoxAN.Size = new System.Drawing.Size(91, 20);
            this.checkBoxAN.TabIndex = 4;
            this.checkBoxAN.Text = "自动换行";
            this.checkBoxAN.UseVisualStyleBackColor = true;
            // 
            // checkBoxRHex
            // 
            this.checkBoxRHex.AutoSize = true;
            this.checkBoxRHex.Checked = true;
            this.checkBoxRHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRHex.Location = new System.Drawing.Point(26, 25);
            this.checkBoxRHex.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRHex.Name = "checkBoxRHex";
            this.checkBoxRHex.Size = new System.Drawing.Size(83, 20);
            this.checkBoxRHex.TabIndex = 3;
            this.checkBoxRHex.Text = "Hex视图";
            this.checkBoxRHex.UseVisualStyleBackColor = true;
            // 
            // labelPortNME
            // 
            this.labelPortNME.AutoSize = true;
            this.labelPortNME.Location = new System.Drawing.Point(128, 101);
            this.labelPortNME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPortNME.Name = "labelPortNME";
            this.labelPortNME.Size = new System.Drawing.Size(72, 16);
            this.labelPortNME.TabIndex = 7;
            this.labelPortNME.Text = "串口名称";
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.Location = new System.Drawing.Point(342, 103);
            this.labelBaudrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(56, 16);
            this.labelBaudrate.TabIndex = 8;
            this.labelBaudrate.Text = "波特率";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(21, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 67);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.AutoSize = true;
            this.checkButton.Checked = true;
            this.checkButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkButton.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkButton.Location = new System.Drawing.Point(332, 134);
            this.checkButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(104, 23);
            this.checkButton.TabIndex = 15;
            this.checkButton.Text = "按键检测";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // button_TestClean
            // 
            this.button_TestClean.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_TestClean.Location = new System.Drawing.Point(449, 129);
            this.button_TestClean.Margin = new System.Windows.Forms.Padding(4);
            this.button_TestClean.Name = "button_TestClean";
            this.button_TestClean.Size = new System.Drawing.Size(83, 31);
            this.button_TestClean.TabIndex = 16;
            this.button_TestClean.Text = "重新检测";
            this.button_TestClean.UseVisualStyleBackColor = true;
            this.button_TestClean.Click += new System.EventHandler(this.button_TestClean_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(100, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 67);
            this.button2.TabIndex = 17;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(184, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 67);
            this.button3.TabIndex = 18;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(270, 18);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 67);
            this.button4.TabIndex = 19;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(350, 18);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 67);
            this.button5.TabIndex = 20;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(12, 24);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 67);
            this.button6.TabIndex = 21;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(12, 103);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 67);
            this.button7.TabIndex = 22;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(12, 182);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 67);
            this.button8.TabIndex = 23;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(12, 258);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 67);
            this.button9.TabIndex = 24;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.Location = new System.Drawing.Point(12, 333);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 67);
            this.button10.TabIndex = 25;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button11.Location = new System.Drawing.Point(351, 22);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 67);
            this.button11.TabIndex = 26;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.Location = new System.Drawing.Point(261, 22);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 67);
            this.button12.TabIndex = 27;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button13.Location = new System.Drawing.Point(284, 523);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(67, 67);
            this.button13.TabIndex = 28;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button14.Location = new System.Drawing.Point(91, 22);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(67, 67);
            this.button14.TabIndex = 29;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button15.Location = new System.Drawing.Point(7, 22);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(67, 67);
            this.button15.TabIndex = 30;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button16.Location = new System.Drawing.Point(9, 358);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(67, 67);
            this.button16.TabIndex = 31;
            this.button16.Text = "16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button17.Location = new System.Drawing.Point(9, 283);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(67, 67);
            this.button17.TabIndex = 32;
            this.button17.Text = "17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button18.Location = new System.Drawing.Point(9, 198);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(67, 67);
            this.button18.TabIndex = 33;
            this.button18.Text = "18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button19.Location = new System.Drawing.Point(9, 112);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(67, 67);
            this.button19.TabIndex = 34;
            this.button19.Text = "19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button20.Location = new System.Drawing.Point(9, 26);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(67, 67);
            this.button20.TabIndex = 35;
            this.button20.Text = "20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(120, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 92);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "顶";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(353, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(88, 432);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "左";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button16);
            this.groupBox2.Controls.Add(this.button19);
            this.groupBox2.Controls.Add(this.button20);
            this.groupBox2.Controls.Add(this.button18);
            this.groupBox2.Controls.Add(this.button17);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 432);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "左";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Location = new System.Drawing.Point(552, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(88, 417);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "右";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button15);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.button14);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Location = new System.Drawing.Point(108, 501);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(432, 91);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "底";
            // 
            // selfcheck
            // 
            this.selfcheck.Location = new System.Drawing.Point(233, 166);
            this.selfcheck.Name = "selfcheck";
            this.selfcheck.Size = new System.Drawing.Size(91, 28);
            this.selfcheck.TabIndex = 39;
            this.selfcheck.Text = "自检测";
            this.selfcheck.UseVisualStyleBackColor = true;
            this.selfcheck.Click += new System.EventHandler(this.selfcheck_Click);
            // 
            // day_check
            // 
            this.day_check.Location = new System.Drawing.Point(345, 166);
            this.day_check.Name = "day_check";
            this.day_check.Size = new System.Drawing.Size(83, 29);
            this.day_check.TabIndex = 41;
            this.day_check.Text = "日检测";
            this.day_check.UseVisualStyleBackColor = true;
            this.day_check.Click += new System.EventHandler(this.day_check_Click);
            // 
            // night_check
            // 
            this.night_check.Location = new System.Drawing.Point(447, 166);
            this.night_check.Name = "night_check";
            this.night_check.Size = new System.Drawing.Size(83, 30);
            this.night_check.TabIndex = 42;
            this.night_check.Text = "夜检测";
            this.night_check.UseVisualStyleBackColor = true;
            this.night_check.Click += new System.EventHandler(this.night_check_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox_Self
            // 
            this.checkBox_Self.AutoSize = true;
            this.checkBox_Self.Location = new System.Drawing.Point(118, 169);
            this.checkBox_Self.Name = "checkBox_Self";
            this.checkBox_Self.Size = new System.Drawing.Size(107, 20);
            this.checkBox_Self.TabIndex = 43;
            this.checkBox_Self.Text = "开启自检测";
            this.checkBox_Self.UseVisualStyleBackColor = true;
            this.checkBox_Self.CheckedChanged += new System.EventHandler(this.checkBox_Self_CheckedChanged);
            // 
            // FormTestSerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 595);
            this.Controls.Add(this.checkBox_Self);
            this.Controls.Add(this.night_check);
            this.Controls.Add(this.day_check);
            this.Controls.Add(this.selfcheck);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_TestClean);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.labelBaudrate);
            this.Controls.Add(this.labelPortNME);
            this.Controls.Add(this.comboBaudrate);
            this.Controls.Add(this.comboPortNme);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonOpenport);
            this.Controls.Add(this.groupDataReceived);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTestSerialPort";
            this.Text = "小屏按键检测 V1.0";
            this.Load += new System.EventHandler(this.FormTestSerialPort_Load);
            this.groupDataReceived.ResumeLayout(false);
            this.groupDataReceived.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenport;
        private System.Windows.Forms.TextBox ContentBox;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboPortNme;
        private System.Windows.Forms.ComboBox comboBaudrate;
        private System.Windows.Forms.GroupBox groupDataReceived;
        private System.Windows.Forms.Label labelPortNME;
        private System.Windows.Forms.Label labelReceiveCount;
        private System.Windows.Forms.CheckBox checkBoxAN;
        private System.Windows.Forms.CheckBox checkBoxRHex;
        private System.Windows.Forms.Label labelBaudrate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkButton;
        private System.Windows.Forms.Button button_TestClean;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button selfcheck;
        private System.Windows.Forms.Button day_check;
        private System.Windows.Forms.Button night_check;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox_Self;
    }
}


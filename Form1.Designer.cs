namespace modbus_projesi_11
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.Button buttonConnect1;
        private System.Windows.Forms.Button buttonDisconnect1;
        private System.Windows.Forms.Button buttonConnect2;
        private System.Windows.Forms.Button buttonDisconnect2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_8 = new System.Windows.Forms.TextBox();
            this.textBox1_4 = new System.Windows.Forms.TextBox();
            this.textBox1_7 = new System.Windows.Forms.TextBox();
            this.textBox1_3 = new System.Windows.Forms.TextBox();
            this.textBox1_6 = new System.Windows.Forms.TextBox();
            this.textBox1_5 = new System.Windows.Forms.TextBox();
            this.textBox1_2 = new System.Windows.Forms.TextBox();
            this.textBox1_1 = new System.Windows.Forms.TextBox();
            this.buttonDisconnect1 = new System.Windows.Forms.Button();
            this.buttonConnect1 = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2_8 = new System.Windows.Forms.TextBox();
            this.textBox2_4 = new System.Windows.Forms.TextBox();
            this.textBox2_7 = new System.Windows.Forms.TextBox();
            this.textBox2_3 = new System.Windows.Forms.TextBox();
            this.textBox2_6 = new System.Windows.Forms.TextBox();
            this.textBox2_5 = new System.Windows.Forms.TextBox();
            this.textBox2_2 = new System.Windows.Forms.TextBox();
            this.textBox2_1 = new System.Windows.Forms.TextBox();
            this.buttonDisconnect2 = new System.Windows.Forms.Button();
            this.buttonConnect2 = new System.Windows.Forms.Button();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1805, 867);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1_8);
            this.tabPage1.Controls.Add(this.textBox1_4);
            this.tabPage1.Controls.Add(this.textBox1_7);
            this.tabPage1.Controls.Add(this.textBox1_3);
            this.tabPage1.Controls.Add(this.textBox1_6);
            this.tabPage1.Controls.Add(this.textBox1_5);
            this.tabPage1.Controls.Add(this.textBox1_2);
            this.tabPage1.Controls.Add(this.textBox1_1);
            this.tabPage1.Controls.Add(this.buttonDisconnect1);
            this.tabPage1.Controls.Add(this.buttonConnect1);
            this.tabPage1.Controls.Add(this.zedGraphControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1797, 838);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Slave ID 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1468, 554);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "NTC 6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1468, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "NTC 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1468, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "NTC 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1468, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "NTC 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1468, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "NTC 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1468, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "NTC 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1468, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "AKIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1468, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "VOLTAJ";
            // 
            // textBox1_8
            // 
            this.textBox1_8.Location = new System.Drawing.Point(1455, 586);
            this.textBox1_8.Name = "textBox1_8";
            this.textBox1_8.Size = new System.Drawing.Size(140, 22);
            this.textBox1_8.TabIndex = 3;
            // 
            // textBox1_4
            // 
            this.textBox1_4.Location = new System.Drawing.Point(1455, 300);
            this.textBox1_4.Name = "textBox1_4";
            this.textBox1_4.Size = new System.Drawing.Size(140, 22);
            this.textBox1_4.TabIndex = 3;
            // 
            // textBox1_7
            // 
            this.textBox1_7.Location = new System.Drawing.Point(1455, 518);
            this.textBox1_7.Name = "textBox1_7";
            this.textBox1_7.Size = new System.Drawing.Size(140, 22);
            this.textBox1_7.TabIndex = 3;
            // 
            // textBox1_3
            // 
            this.textBox1_3.Location = new System.Drawing.Point(1455, 232);
            this.textBox1_3.Name = "textBox1_3";
            this.textBox1_3.Size = new System.Drawing.Size(140, 22);
            this.textBox1_3.TabIndex = 3;
            // 
            // textBox1_6
            // 
            this.textBox1_6.Location = new System.Drawing.Point(1455, 444);
            this.textBox1_6.Name = "textBox1_6";
            this.textBox1_6.Size = new System.Drawing.Size(140, 22);
            this.textBox1_6.TabIndex = 3;
            // 
            // textBox1_5
            // 
            this.textBox1_5.Location = new System.Drawing.Point(1455, 377);
            this.textBox1_5.Name = "textBox1_5";
            this.textBox1_5.Size = new System.Drawing.Size(140, 22);
            this.textBox1_5.TabIndex = 3;
            // 
            // textBox1_2
            // 
            this.textBox1_2.Location = new System.Drawing.Point(1455, 159);
            this.textBox1_2.Name = "textBox1_2";
            this.textBox1_2.Size = new System.Drawing.Size(140, 22);
            this.textBox1_2.TabIndex = 3;
            // 
            // textBox1_1
            // 
            this.textBox1_1.Location = new System.Drawing.Point(1455, 91);
            this.textBox1_1.Name = "textBox1_1";
            this.textBox1_1.Size = new System.Drawing.Size(140, 22);
            this.textBox1_1.TabIndex = 3;
            // 
            // buttonDisconnect1
            // 
            this.buttonDisconnect1.Location = new System.Drawing.Point(120, 7);
            this.buttonDisconnect1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDisconnect1.Name = "buttonDisconnect1";
            this.buttonDisconnect1.Size = new System.Drawing.Size(100, 28);
            this.buttonDisconnect1.TabIndex = 2;
            this.buttonDisconnect1.Text = "Disconnect";
            this.buttonDisconnect1.UseVisualStyleBackColor = true;
            this.buttonDisconnect1.Click += new System.EventHandler(this.buttonDisconnect1_Click);
            // 
            // buttonConnect1
            // 
            this.buttonConnect1.Location = new System.Drawing.Point(12, 7);
            this.buttonConnect1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect1.Name = "buttonConnect1";
            this.buttonConnect1.Size = new System.Drawing.Size(100, 28);
            this.buttonConnect1.TabIndex = 1;
            this.buttonConnect1.Text = "Connect";
            this.buttonConnect1.UseVisualStyleBackColor = true;
            this.buttonConnect1.Click += new System.EventHandler(this.buttonConnect1_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(8, 43);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1367, 615);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.textBox2_8);
            this.tabPage2.Controls.Add(this.textBox2_4);
            this.tabPage2.Controls.Add(this.textBox2_7);
            this.tabPage2.Controls.Add(this.textBox2_3);
            this.tabPage2.Controls.Add(this.textBox2_6);
            this.tabPage2.Controls.Add(this.textBox2_5);
            this.tabPage2.Controls.Add(this.textBox2_2);
            this.tabPage2.Controls.Add(this.textBox2_1);
            this.tabPage2.Controls.Add(this.buttonDisconnect2);
            this.tabPage2.Controls.Add(this.buttonConnect2);
            this.tabPage2.Controls.Add(this.zedGraphControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1797, 838);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Slave ID 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2_8
            // 
            this.textBox2_8.Location = new System.Drawing.Point(1495, 592);
            this.textBox2_8.Name = "textBox2_8";
            this.textBox2_8.Size = new System.Drawing.Size(140, 22);
            this.textBox2_8.TabIndex = 5;
            // 
            // textBox2_4
            // 
            this.textBox2_4.Location = new System.Drawing.Point(1495, 306);
            this.textBox2_4.Name = "textBox2_4";
            this.textBox2_4.Size = new System.Drawing.Size(140, 22);
            this.textBox2_4.TabIndex = 6;
            // 
            // textBox2_7
            // 
            this.textBox2_7.Location = new System.Drawing.Point(1495, 524);
            this.textBox2_7.Name = "textBox2_7";
            this.textBox2_7.Size = new System.Drawing.Size(140, 22);
            this.textBox2_7.TabIndex = 7;
            // 
            // textBox2_3
            // 
            this.textBox2_3.Location = new System.Drawing.Point(1495, 238);
            this.textBox2_3.Name = "textBox2_3";
            this.textBox2_3.Size = new System.Drawing.Size(140, 22);
            this.textBox2_3.TabIndex = 8;
            // 
            // textBox2_6
            // 
            this.textBox2_6.Location = new System.Drawing.Point(1495, 451);
            this.textBox2_6.Name = "textBox2_6";
            this.textBox2_6.Size = new System.Drawing.Size(140, 22);
            this.textBox2_6.TabIndex = 9;
            // 
            // textBox2_5
            // 
            this.textBox2_5.Location = new System.Drawing.Point(1495, 383);
            this.textBox2_5.Name = "textBox2_5";
            this.textBox2_5.Size = new System.Drawing.Size(140, 22);
            this.textBox2_5.TabIndex = 10;
            // 
            // textBox2_2
            // 
            this.textBox2_2.Location = new System.Drawing.Point(1495, 165);
            this.textBox2_2.Name = "textBox2_2";
            this.textBox2_2.Size = new System.Drawing.Size(140, 22);
            this.textBox2_2.TabIndex = 11;
            // 
            // textBox2_1
            // 
            this.textBox2_1.Location = new System.Drawing.Point(1495, 97);
            this.textBox2_1.Name = "textBox2_1";
            this.textBox2_1.Size = new System.Drawing.Size(140, 22);
            this.textBox2_1.TabIndex = 12;
            // 
            // buttonDisconnect2
            // 
            this.buttonDisconnect2.Location = new System.Drawing.Point(120, 7);
            this.buttonDisconnect2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDisconnect2.Name = "buttonDisconnect2";
            this.buttonDisconnect2.Size = new System.Drawing.Size(100, 28);
            this.buttonDisconnect2.TabIndex = 4;
            this.buttonDisconnect2.Text = "Disconnect";
            this.buttonDisconnect2.UseVisualStyleBackColor = true;
            this.buttonDisconnect2.Click += new System.EventHandler(this.buttonDisconnect2_Click);
            // 
            // buttonConnect2
            // 
            this.buttonConnect2.Location = new System.Drawing.Point(12, 7);
            this.buttonConnect2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect2.Name = "buttonConnect2";
            this.buttonConnect2.Size = new System.Drawing.Size(100, 28);
            this.buttonConnect2.TabIndex = 3;
            this.buttonConnect2.Text = "Connect";
            this.buttonConnect2.UseVisualStyleBackColor = true;
            this.buttonConnect2.Click += new System.EventHandler(this.buttonConnect2_Click);
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(8, 43);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(1408, 674);
            this.zedGraphControl2.TabIndex = 1;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(1468, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "VOLTAJ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1468, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "AKIM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1468, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "NTC 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(1468, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "NTC 1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(1468, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "NTC 4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(1468, 486);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "NTC 5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(1468, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "NTC 2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(1468, 554);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "NTC 6";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(1512, 559);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "NTC 6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(1512, 272);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 20);
            this.label18.TabIndex = 14;
            this.label18.Text = "NTC 2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(1512, 491);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 20);
            this.label19.TabIndex = 15;
            this.label19.Text = "NTC 5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(1512, 419);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 20);
            this.label20.TabIndex = 16;
            this.label20.Text = "NTC 4";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(1512, 204);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 20);
            this.label21.TabIndex = 17;
            this.label21.Text = "NTC 1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(1512, 351);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 20);
            this.label22.TabIndex = 18;
            this.label22.Text = "NTC 3";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(1512, 132);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 20);
            this.label23.TabIndex = 19;
            this.label23.Text = "AKIM";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(1512, 64);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 20);
            this.label24.TabIndex = 20;
            this.label24.Text = "VOLTAJ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 929);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Modbus Uygulaması";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox textBox1_8;
        private System.Windows.Forms.TextBox textBox1_4;
        private System.Windows.Forms.TextBox textBox1_7;
        private System.Windows.Forms.TextBox textBox1_3;
        private System.Windows.Forms.TextBox textBox1_6;
        private System.Windows.Forms.TextBox textBox1_5;
        private System.Windows.Forms.TextBox textBox1_2;
        private System.Windows.Forms.TextBox textBox1_1;
        private System.Windows.Forms.TextBox textBox2_8;
        private System.Windows.Forms.TextBox textBox2_4;
        private System.Windows.Forms.TextBox textBox2_7;
        private System.Windows.Forms.TextBox textBox2_3;
        private System.Windows.Forms.TextBox textBox2_6;
        private System.Windows.Forms.TextBox textBox2_5;
        private System.Windows.Forms.TextBox textBox2_2;
        private System.Windows.Forms.TextBox textBox2_1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}

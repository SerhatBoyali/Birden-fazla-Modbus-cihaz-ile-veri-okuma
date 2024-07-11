using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using Modbus.Device;
using ZedGraph;

namespace modbus_projesi_11
{
    public partial class Form1 : Form
    {
        private IModbusSerialMaster master;
        private SerialPort port;
        private GraphPane myPane1, myPane2;
        private PointPairList[] pointPairLists1, pointPairLists2;
        private LineItem[] curves1, curves2;
        private int time1, time2;
        private TextBox[] textBoxes1, textBoxes2;

        public Form1()
        {
            InitializeComponent();
            InitializeModbus();
            InitializeGraph1();
            InitializeGraph2();
            InitializeTextBoxes();
        }

        private void InitializeModbus()
        {
            try
            {
                port = new SerialPort("COM6"); // Seri port adını değiştirin
                port.BaudRate = 9600;
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;

                if (!port.IsOpen)
                {
                    port.Open();
                }

                // Modbus master oluştur
                master = ModbusSerialMaster.CreateRtu(port);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Seri port açılırken hata oluştu: {ex.Message}");
            }
        }

        private void InitializeGraph1()
        {
            // ZedGraphControl1 için grafik alanını ayarlayın
            myPane1 = zedGraphControl1.GraphPane;
            myPane1.Title.Text = "Modbus Veri Grafiği - Slave ID 1";
            myPane1.XAxis.Title.Text = "Zaman";
            myPane1.YAxis.Title.Text = "Değer";

            pointPairLists1 = new PointPairList[8]; // 8 adet float veri için
            curves1 = new LineItem[8];
            Color[] colors = { Color.Blue, Color.Red, Color.Green, Color.Purple, Color.Orange, Color.Brown, Color.Pink, Color.Gray };

            for (int i = 0; i < 8; i++)
            {
                pointPairLists1[i] = new PointPairList();
                curves1[i] = myPane1.AddCurve($"Veri {i + 1}", pointPairLists1[i], colors[i], SymbolType.None);
            }
        }

        private void InitializeGraph2()
        {
            // ZedGraphControl2 için grafik alanını ayarlayın
            myPane2 = zedGraphControl2.GraphPane;
            myPane2.Title.Text = "Modbus Veri Grafiği - Slave ID 2";
            myPane2.XAxis.Title.Text = "Zaman";
            myPane2.YAxis.Title.Text = "Değer";

            pointPairLists2 = new PointPairList[8]; // 8 adet float veri için
            curves2 = new LineItem[8];
            Color[] colors = { Color.Blue, Color.Red, Color.Green, Color.Purple, Color.Orange, Color.Brown, Color.Pink, Color.Gray };

            for (int i = 0; i < 8; i++)
            {
                pointPairLists2[i] = new PointPairList();
                curves2[i] = myPane2.AddCurve($"Veri {i + 1}", pointPairLists2[i], colors[i], SymbolType.None);
            }
        }

        private void InitializeTextBoxes()
        {
            textBoxes1 = new TextBox[8];
            textBoxes2 = new TextBox[8];

            int tabPageWidth1 = tabPage1.Width;
            int tabPageWidth2 = tabPage2.Width;
            int textBoxWidth = 100; // TextBox genişliği

            for (int i = 0; i < 8; i++)
            {
                // TabPage1 için TextBox'ları oluştur ve ekle
                textBoxes1[i] = new TextBox
                {
                    Location = new Point(tabPageWidth1 - textBoxWidth - 10, 10 + i * 30), // Sağda hizalanmış
                    Width = textBoxWidth,
                    Visible = true
                };
                tabPage1.Controls.Add(textBoxes1[i]);

                // TabPage2 için TextBox'ları oluştur ve ekle
                textBoxes2[i] = new TextBox
                {
                    Location = new Point(tabPageWidth2 - textBoxWidth - 10, 10 + i * 30), // Sağda hizalanmış
                    Width = textBoxWidth,
                    Visible = true
                };
                tabPage2.Controls.Add(textBoxes2[i]);
            }
        }

        private void buttonConnect1_Click(object sender, EventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Seri port açık değil!");
            }
        }

        private void buttonDisconnect1_Click(object sender, EventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                timer1.Stop();
            }
        }

        private void buttonConnect2_Click(object sender, EventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                timer2.Start();
            }
            else
            {
                MessageBox.Show("Seri port açık değil!");
            }
        }

        private void buttonDisconnect2_Click(object sender, EventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                timer2.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadModbusData(1, pointPairLists1, ref time1, zedGraphControl1, textBoxes1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ReadModbusData(2, pointPairLists2, ref time2, zedGraphControl2, textBoxes2);
        }

        private void ReadModbusData(byte slaveId, PointPairList[] pointPairLists, ref int time, ZedGraphControl zedGraphControl, TextBox[] textBoxes)
        {
            try
            {
                if (port != null && port.IsOpen)
                {
                    ushort startAddress = 0;
                    ushort numRegisters = 16; // 8 adet float veri için 16 adet register okunmalı

                    ushort[] registers = master.ReadHoldingRegisters(slaveId, startAddress, numRegisters);

                    // İlk değeri tam sayı olarak oku
                    int firstValue = registers[0];

                    // İlk değeri grafiğe ve TextBox'a ekle
                    pointPairLists[0].Add(time, firstValue);
                    textBoxes[0].Text = firstValue.ToString();

                    // Geri kalan değerleri float olarak oku
                    for (int i = 1; i < 8; i++)
                    {
                        float value = ConvertRegistersToFloat(registers[i * 2 + 1], registers[i * 2]);
                        pointPairLists[i].Add(time, value);
                        textBoxes[i].Text = value.ToString();
                    }
                    time++;

                    // Grafik güncellemesi
                    zedGraphControl.AxisChange();
                    zedGraphControl.Invalidate();
                }
                else
                {
                    MessageBox.Show("Seri port açık değil!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private float ConvertRegistersToFloat(ushort highOrderByte, ushort lowOrderByte)
        {
            // 2 adet 8-bit byte'ı 16-bit değere dönüştür
            ushort combinedValue = (ushort)((highOrderByte << 8) | lowOrderByte);

            // Dönüştürülmüş 16-bit değeri float'a dönüştür
            return combinedValue / 10.0f; // Örneğin, sıcaklık değeri 10'a bölünerek float değeri elde ediliyor
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                if (port != null && port.IsOpen)
                {
                    port.Close();
                    port.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Seri port kapatılırken hata oluştu: {ex.Message}");
            }

            base.OnFormClosing(e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LD08_tester
{
  public partial class Form1 : Form
  {
    //private Thread readThread;
    //delegate void SetDataCallback(int data);
    delegate void parsePacketCallback();

    //private Thread drawThread;

    private int data_length = 0;
    private int lds_rpm = 0;
    private double start_angle = 0;
    private double end_angle = 0;
    private int timestamp = 0;
    private int timestamp_temp = 0;

    private int[] parse_data = new int[47];
    private int write_index = 0;
    private int read_index = 0;
    private int parseStatus = 0;
    private byte[] CrcTable = new byte[256] {
      0x00, 0x4d, 0x9a, 0xd7, 0x79, 0x34, 0xe3,
      0xae, 0xf2, 0xbf, 0x68, 0x25, 0x8b, 0xc6, 0x11, 0x5c, 0xa9, 0xe4, 0x33,
      0x7e, 0xd0, 0x9d, 0x4a, 0x07, 0x5b, 0x16, 0xc1, 0x8c, 0x22, 0x6f, 0xb8,
      0xf5, 0x1f, 0x52, 0x85, 0xc8, 0x66, 0x2b, 0xfc, 0xb1, 0xed, 0xa0, 0x77,
      0x3a, 0x94, 0xd9, 0x0e, 0x43, 0xb6, 0xfb, 0x2c, 0x61, 0xcf, 0x82, 0x55,
      0x18, 0x44, 0x09, 0xde, 0x93, 0x3d, 0x70, 0xa7, 0xea, 0x3e, 0x73, 0xa4,
      0xe9, 0x47, 0x0a, 0xdd, 0x90, 0xcc, 0x81, 0x56, 0x1b, 0xb5, 0xf8, 0x2f,
      0x62, 0x97, 0xda, 0x0d, 0x40, 0xee, 0xa3, 0x74, 0x39, 0x65, 0x28, 0xff,
      0xb2, 0x1c, 0x51, 0x86, 0xcb, 0x21, 0x6c, 0xbb, 0xf6, 0x58, 0x15, 0xc2,
      0x8f, 0xd3, 0x9e, 0x49, 0x04, 0xaa, 0xe7, 0x30, 0x7d, 0x88, 0xc5, 0x12,
      0x5f, 0xf1, 0xbc, 0x6b, 0x26, 0x7a, 0x37, 0xe0, 0xad, 0x03, 0x4e, 0x99,
      0xd4, 0x7c, 0x31, 0xe6, 0xab, 0x05, 0x48, 0x9f, 0xd2, 0x8e, 0xc3, 0x14,
      0x59, 0xf7, 0xba, 0x6d, 0x20, 0xd5, 0x98, 0x4f, 0x02, 0xac, 0xe1, 0x36,
      0x7b, 0x27, 0x6a, 0xbd, 0xf0, 0x5e, 0x13, 0xc4, 0x89, 0x63, 0x2e, 0xf9,
      0xb4, 0x1a, 0x57, 0x80, 0xcd, 0x91, 0xdc, 0x0b, 0x46, 0xe8, 0xa5, 0x72,
      0x3f, 0xca, 0x87, 0x50, 0x1d, 0xb3, 0xfe, 0x29, 0x64, 0x38, 0x75, 0xa2,
      0xef, 0x41, 0x0c, 0xdb, 0x96, 0x42, 0x0f, 0xd8, 0x95, 0x3b, 0x76, 0xa1,
      0xec, 0xb0, 0xfd, 0x2a, 0x67, 0xc9, 0x84, 0x53, 0x1e, 0xeb, 0xa6, 0x71,
      0x3c, 0x92, 0xdf, 0x08, 0x45, 0x19, 0x54, 0x83, 0xce, 0x60, 0x2d, 0xfa,
      0xb7, 0x5d, 0x10, 0xc7, 0x8a, 0x24, 0x69, 0xbe, 0xf3, 0xaf, 0xe2, 0x35,
      0x78, 0xd6, 0x9b, 0x4c, 0x01, 0xf4, 0xb9, 0x6e, 0x23, 0x8d, 0xc0, 0x17,
      0x5a, 0x06, 0x4b, 0x9c, 0xd1, 0x7f, 0x32, 0xe5, 0xa8
    };

    public Form1()
    {
      InitializeComponent();

      //drawThread = new Thread(drawLDS);
      //drawThread.Start();

      string[] portNames = SerialPort.GetPortNames();
      foreach (string portnumber in portNames)
      {
        serialComboBox.Items.Add(portnumber);
        serialComboBox.SelectedIndex = 0;
      }

      if (portNames.Length != 0)
      {
        button_open.Enabled = true;
      }
      else
      {
        button_open.Enabled = false;
      }

      serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.KeyPreview = true;
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        button_open.PerformClick();
      }
      if (e.KeyCode == Keys.Escape)
      {
        button_close.PerformClick();
      }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      //if (processThread != null && processThread.IsAlive)
      //{
      //  processThread.Abort();
      //}
      //if (readThread != null && readThread.IsAlive)
      //{
      //  readThread.Abort();
      //}
    }

    private void button_open_Click(object sender, EventArgs e)
    {
      try
      {
        if (serialPort1.IsOpen == false)
        {
          Array.Clear(parse_data, 0, parse_data.Length);

          serialPort1.PortName = serialComboBox.SelectedItem.ToString();
          serialPort1.BaudRate = 115200;
          serialPort1.DataBits = 8;
          serialPort1.StopBits = StopBits.One;
          serialPort1.Parity = Parity.None;
          serialPort1.Open();

          textBox.AppendText(Environment.NewLine + "포트가 열렸습니다." + Environment.NewLine);

          //readThread = new Thread(Read);
          //readThread.Start();
          //processThread = new Thread(Process);
          //processThread.Start();
        }
        else
        {
          textBox.AppendText(Environment.NewLine + "포트가 이미 열려있습니다." + Environment.NewLine);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void button_close_Click(object sender, EventArgs e)
    {
      try
      {
        if (serialPort1.IsOpen)
        {
          Array.Clear(parse_data, 0, parse_data.Length);
          serialPort1.Close();
          //serialPort1.DiscardInBuffer();
          //serialPort1.DiscardOutBuffer();

          textBox.AppendText(Environment.NewLine + "포트를 닫았습니다." + Environment.NewLine);
        }
        else
        {
          textBox.AppendText(Environment.NewLine + "포트가 이미 닫혀있습니다." + Environment.NewLine);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      int rx_data = serialPort1.ReadChar();
      parse_data[write_index] = rx_data;
      write_index++;
      if (write_index == parse_data.Length)
      {
        write_index = 0;
        BeginInvoke(new parsePacketCallback(parsePacket));
      //BeginInvoke(new SetDataCallback(Read), new object[] { rx_data });
      }
    }

    private void Read(int data)
    {
      this.Invoke((MethodInvoker)delegate
      {
        textBox.AppendText(string.Format("{0:X2} ", data));
      });

      //parsePacket(data);
    }

    private void parsePacket()
    {
      read_index = 0;
      parseStatus = 0;

      while (read_index < parse_data.Length)
      {
        switch (parseStatus)
        {
          // Find Header 0x54
          case 0:
            if (parse_data[read_index] == 0x54)
            {
              //parse_data[read_index] = data;
              read_index++;
              parseStatus = 1;
            }
            //else
            //{
            //  read_index = 0;
            //  parseStatus = 0;
            //}  
            break;

          // Find Length 0x2C
          case 1:
            if (parse_data[read_index] == 0x2C)
            {
              //parse_data[read_index] = data;
              read_index++;
              parseStatus = 2;
            }
            else
            {
              Array.Clear(parse_data, 0, parse_data.Length);
              read_index = 47;
            }
            break;

          // Get the rest data
          case 2:
            int crc = 0;
            for (int count = 0; count < parse_data.Length - 1;)
            {
              crc = CrcTable[(byte)(crc ^ parse_data[count]) & 0xFF];
              this.Invoke((MethodInvoker)delegate
              {
                textBox.AppendText(string.Format("{0:X2} ", parse_data[count]));
              });
              count++;
            }
            this.Invoke((MethodInvoker)delegate
            {
              textBox.AppendText(string.Format("{0:X2} ", parse_data[46]));
            });

            lds_rpm = (parse_data[3] << 8) + parse_data[2];
            data_length = parse_data[1];
            end_angle = ((parse_data[43] << 8) + parse_data[42]) / 100.0;
            start_angle = ((parse_data[5] << 8) + parse_data[4]) / 100.0;
            timestamp = (parse_data[45] << 8) + parse_data[44];
            timestamp_temp = timestamp;

            this.Invoke((MethodInvoker)delegate
            {
              textBox.AppendText(Environment.NewLine + "===[" + string.Format("{0:X2} ", parse_data[46]) + ", " + string.Format("{0:X2} ", crc) + "]===" + Environment.NewLine);
              textBox_rpm.Text = lds_rpm.ToString();
              textBox_data_length.Text = data_length.ToString();
              textBox_start_angle.Text = start_angle.ToString();
              textBox_end_angle.Text = end_angle.ToString();
              textBox_time.Text = timestamp.ToString();
              textBox_angle_gap.Text = (end_angle - start_angle).ToString();
              textBox_time_gap.Text = (timestamp - timestamp_temp).ToString();
              textBox_time_gap.Text = timestamp_temp.ToString();
            });

            Array.Clear(parse_data, 0, parse_data.Length);
            read_index = 47;
            break;

          default:
            break;
        }
      }
    }

    //private void Process()
    //{
    //  int temp_index = 0;
    //  while (_continue)
    //  {
    //    if (raw_data[read_index] == 0x54)
    //    {
    //      parse_data[temp_index] = raw_data[read_index];
    //      temp_index = temp_index + 1;
    //      read_index = read_index + 1;
    //      if (read_index >= 100)
    //      {
    //        read_index = 0;
    //      }
    //      if (raw_data[read_index] == 0x2C)
    //      {
    //        for (int count = 0; count <46; count++)
    //        {
    //          parse_data[temp_index] = raw_data[read_index];
    //          temp_index = temp_index + 1;
    //          if (temp_index > 47)
    //            temp_index = 0;
    //          read_index = read_index + 1;
    //          if(read_index >= 100)
    //          {
    //            read_index = 0;
    //          }
    //        }
    //        if(!checkCRC())
    //        {
    //          // CRC ERROR!!!
    //          this.Invoke((MethodInvoker)delegate
    //          {
    //            textBox.Text += "[ERROR] Invalid CRC!!!";
    //          });
    //          //Array.Clear(raw_data, 0, raw_data.Length);
    //          //read_index = 0;
    //          read_index = 0;
    //          temp_index = 0;
    //          Array.Clear(parse_data, 0, parse_data.Length);
    //        }
    //        this.Invoke((MethodInvoker)delegate
    //        {
    //          textBox_rpm.Text = lds_rpm.ToString();
    //          textBox_data_length.Text = data_length.ToString();
    //          textBox_start_angle.Text = start_angle.ToString();
    //          textBox_end_angle.Text = end_angle.ToString();
    //          textBox_time.Text = timestamp.ToString();
    //          textBox_angle_gap.Text = (end_angle - start_angle).ToString();
    //          //textBox_time_gap.Text = (timestamp - timestamp_temp).ToString();
    //          textBox_time_gap.Text = timestamp_temp.ToString();
    //        });
    //      }
    //      else
    //      {
    //        read_index = read_index + 1;
    //        temp_index = 0;
    //        if (read_index >= 100)
    //        {
    //          read_index = 0;
    //        }
    //      }
    //    }
    //    else
    //    {
    //      read_index = read_index + 1;
    //      temp_index = 0;
    //      if (read_index >= 100)
    //      {
    //        read_index = 0;
    //      }
    //    }
    //  }

    //  if (_continue == false)
    //  {
    //    try
    //    {
    //      processThread.Join();
    //      processThread.Abort();
    //    }
    //    catch (Exception ex)
    //    {
    //      //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //  }
    //}

    //private bool checkCRC()
    //{
    //  int crc = 0;
    //  int i = 0;

    //  //this.Invoke((MethodInvoker)delegate
    //  //{
    //  //  textBox.Text += Environment.NewLine + "==================" + Environment.NewLine;
    //  //});

    //  for (i = 0; i < 47; i++)
    //  {
    //    crc = CrcTable[(crc ^ parse_data[i]) & 0xFF];
    //    this.Invoke((MethodInvoker)delegate
    //    {
    //      textBox.Text = textBox.Text + string.Format("{0:X2} ", parse_data[i]);
    //    });
    //  }
    //  this.Invoke((MethodInvoker)delegate
    //  {
    //    textBox.Text = textBox.Text + Environment.NewLine + "Cal CRC : " + string.Format("{0:X2} ", crc) + ", CRC : " + string.Format("{0:X2} ", parse_data[46]) + Environment.NewLine;
    //  });
    //  if (crc == parse_data[46])
    //  {
    //    data_length = parse_data[1];
    //    lds_rpm = (parse_data[3] << 8) + parse_data[2];
    //    start_angle = ((parse_data[5] << 8) + parse_data[4]) / 100.0;
    //    end_angle = ((parse_data[43] << 8) + parse_data[42]) / 100.0;
    //    timestamp = (parse_data[45] << 8) + parse_data[44];
    //    timestamp_temp = timestamp;
    //    return true;
    //  }
    //  else
    //  {
    //    // CRC ERROR!!!
    //    this.Invoke((MethodInvoker)delegate
    //    {
    //      textBox.Text += string.Format("[ERROR] Invalid calc CRC: {0:X2}", crc) + Environment.NewLine;
    //    });
    //    return false;
    //  }
    //}

    //private void drawLDS()
    //{
    //  System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
    //  System.Drawing.Graphics formGraphics;
    //  formGraphics = this.CreateGraphics();
    //  formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
    //  myBrush.Dispose();
    //  formGraphics.Dispose();
    //}
  }
}

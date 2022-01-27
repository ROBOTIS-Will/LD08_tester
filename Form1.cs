using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace LD08_tester
{
  public partial class Form1 : Form
  {
    private int data_length = 0;
    private int lds_rpm = 0;
    private double start_angle = 0;
    private double end_angle = 0;
    private double angle_gap = 0;
    private int timestamp = 0;

    private int avg_rpm = 0;
    private double avg_pitch = 0;
    private int avg_count = 0;

    private int print_frequency = 0;

    private Assembly myAssembly;
    private Stream passimage;
    private Stream failimage;

    private System.Timers.Timer timer;

    public Form1()
    {
      InitializeComponent();

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

      //serialPort1.DataReceived += PortDataReceived;
      //serialPort1.DataReceived += new SerialDataReceivedEventHandler(PortDataReceived);

      timer = new System.Timers.Timer();
      timer.Interval = 5000;
      timer.Elapsed += OnTimedEvent;
      timer.AutoReset = true;

      myAssembly = Assembly.GetExecutingAssembly();
      passimage = myAssembly.GetManifestResourceStream("LD08_tester.pass.png");
      failimage = myAssembly.GetManifestResourceStream("LD08_tester.fail.png");
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.KeyPreview = true;
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      try
      {
        if (e.KeyCode == Keys.Enter)
        {
          button_open.PerformClick();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Key Down Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void button_open_Click(object sender, EventArgs e)
    {
      try
      {
        if (serialPort1.IsOpen == false)
        {
          serialPort1.PortName = serialComboBox.SelectedItem.ToString();
          serialPort1.BaudRate = 115200;
          serialPort1.DataBits = 8;
          serialPort1.StopBits = StopBits.One;
          serialPort1.Parity = Parity.None;
          serialPort1.Open();
          serialPort1.DataReceived += new SerialDataReceivedEventHandler(PortDataReceived);

          textBox.Clear();
          textBox.AppendText(Environment.NewLine + "Port Opened." + Environment.NewLine);
          button_open.Text = "Close Port [Enter]";
          timer.Enabled = true;
        }
        else
        {
          try
          {
            serialPort1.DataReceived -= new SerialDataReceivedEventHandler(PortDataReceived);
            
            serialPort1.DiscardInBuffer();
            serialPort1.Dispose();
            serialPort1.Close();

            avg_count = 0;
            avg_rpm = 0;
            avg_pitch = 0;
            print_frequency = 0;
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message, "Port Closing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          pictureBox_passfail.Image = null;

          textBox.AppendText(Environment.NewLine + "Port Closed." + Environment.NewLine);
          button_open.Text = "Open Port [Enter]";
          timer.Enabled = false;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Port Control Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      if (serialPort1.IsOpen)
      {
        try
        {
          byte[] rx_data = new byte[serialPort1.BytesToRead];

          serialPort1.Read(rx_data, 0, rx_data.Length);
          if (rx_data.Length == 47)
          {
            parsePacket(rx_data);
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "PortDataReceived Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void parsePacket(byte[] rx_data)
    {
      try
      {
        if (print_frequency == 10)
        {
          // Display Packet
          string text_temp = "";
          for (int i = 0; i < 47; i++)
          {
            text_temp += string.Format("{0:X2} ", rx_data[i]);
          }

          lds_rpm = (rx_data[3] << 8) + rx_data[2];
          data_length = rx_data[1];
          end_angle = ((rx_data[43] << 8) + rx_data[42]) / 100.0;
          start_angle = ((rx_data[5] << 8) + rx_data[4]) / 100.0;

          if (start_angle > end_angle)
          {
            angle_gap = end_angle - start_angle + 360.0;
          }
          else
          {
            angle_gap = end_angle - start_angle;
          }
          timestamp = (rx_data[45] << 8) + rx_data[44];
          avg_rpm = (avg_rpm * avg_count + lds_rpm) / (avg_count + 1);
          avg_pitch = (avg_pitch * avg_count + angle_gap) / (avg_count + 1);

          this.BeginInvoke((MethodInvoker)delegate
          {
            textBox_rpm.Text = lds_rpm.ToString();
            textBox_data_length.Text = data_length.ToString();
            textBox_start_angle.Text = start_angle.ToString();
            textBox_end_angle.Text = end_angle.ToString();
            textBox_time.Text = timestamp.ToString();
            textBox_angle_gap.Text = string.Format("{0:00.00}", angle_gap);
            textBox_avg_rpm.Text = avg_rpm.ToString();
            textBox_avg_pitch.Text = string.Format("{0:00.00}", avg_pitch);
            textBox.AppendText(text_temp);
          });

          print_frequency = 0;
          avg_count++;
        }
        else
        {
          print_frequency++;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Packet Parsing error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
    {
      try
      {
        if (data_length == 44 && avg_rpm > 1800)
        {
          pictureBox_passfail.Image = Image.FromStream(passimage);
        }
        else
        {
          pictureBox_passfail.Image = Image.FromStream(failimage);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Display Image error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
}
  }
}

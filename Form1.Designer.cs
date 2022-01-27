namespace LD08_tester
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.serialComboBox = new System.Windows.Forms.ComboBox();
      this.button_open = new System.Windows.Forms.Button();
      this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label10 = new System.Windows.Forms.Label();
      this.textBox_angle_gap = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textBox_data_length = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBox_time = new System.Windows.Forms.TextBox();
      this.textBox_end_angle = new System.Windows.Forms.TextBox();
      this.textBox_start_angle = new System.Windows.Forms.TextBox();
      this.textBox_rpm = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.textBox = new System.Windows.Forms.TextBox();
      this.textBox_avg_rpm = new System.Windows.Forms.TextBox();
      this.textBox_avg_pitch = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.pictureBox_passfail = new System.Windows.Forms.PictureBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passfail)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(25, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "Serial Port";
      // 
      // serialComboBox
      // 
      this.serialComboBox.FormattingEnabled = true;
      this.serialComboBox.Location = new System.Drawing.Point(100, 6);
      this.serialComboBox.Name = "serialComboBox";
      this.serialComboBox.Size = new System.Drawing.Size(127, 20);
      this.serialComboBox.TabIndex = 2;
      // 
      // button_open
      // 
      this.button_open.Location = new System.Drawing.Point(100, 43);
      this.button_open.Name = "button_open";
      this.button_open.Size = new System.Drawing.Size(127, 23);
      this.button_open.TabIndex = 1;
      this.button_open.Text = "Open Port [Enter]";
      this.button_open.UseVisualStyleBackColor = true;
      this.button_open.Click += new System.EventHandler(this.button_open_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.textBox_angle_gap);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.textBox_data_length);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.textBox_time);
      this.groupBox1.Controls.Add(this.textBox_end_angle);
      this.groupBox1.Controls.Add(this.textBox_start_angle);
      this.groupBox1.Controls.Add(this.textBox_rpm);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Location = new System.Drawing.Point(14, 98);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(213, 204);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "LDS RAW Data";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(31, 53);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(84, 12);
      this.label10.TabIndex = 11;
      this.label10.Text = "Speed [RPM]";
      // 
      // textBox_angle_gap
      // 
      this.textBox_angle_gap.Location = new System.Drawing.Point(119, 170);
      this.textBox_angle_gap.Name = "textBox_angle_gap";
      this.textBox_angle_gap.Size = new System.Drawing.Size(87, 21);
      this.textBox_angle_gap.TabIndex = 8;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(8, 173);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(107, 12);
      this.label7.TabIndex = 10;
      this.label7.Text = "Angle Pitch [Deg]";
      // 
      // textBox_data_length
      // 
      this.textBox_data_length.Location = new System.Drawing.Point(119, 20);
      this.textBox_data_length.Name = "textBox_data_length";
      this.textBox_data_length.Size = new System.Drawing.Size(87, 21);
      this.textBox_data_length.TabIndex = 3;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(43, 23);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(72, 12);
      this.label6.TabIndex = 8;
      this.label6.Text = "Data Length";
      // 
      // textBox_time
      // 
      this.textBox_time.Location = new System.Drawing.Point(119, 140);
      this.textBox_time.Name = "textBox_time";
      this.textBox_time.Size = new System.Drawing.Size(87, 21);
      this.textBox_time.TabIndex = 7;
      // 
      // textBox_end_angle
      // 
      this.textBox_end_angle.Location = new System.Drawing.Point(119, 110);
      this.textBox_end_angle.Name = "textBox_end_angle";
      this.textBox_end_angle.Size = new System.Drawing.Size(87, 21);
      this.textBox_end_angle.TabIndex = 6;
      // 
      // textBox_start_angle
      // 
      this.textBox_start_angle.Location = new System.Drawing.Point(119, 80);
      this.textBox_start_angle.Name = "textBox_start_angle";
      this.textBox_start_angle.Size = new System.Drawing.Size(87, 21);
      this.textBox_start_angle.TabIndex = 5;
      // 
      // textBox_rpm
      // 
      this.textBox_rpm.Location = new System.Drawing.Point(119, 50);
      this.textBox_rpm.Name = "textBox_rpm";
      this.textBox_rpm.Size = new System.Drawing.Size(87, 21);
      this.textBox_rpm.TabIndex = 4;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(47, 143);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(68, 12);
      this.label5.TabIndex = 3;
      this.label5.Text = "Time [ms]";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 113);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(101, 12);
      this.label4.TabIndex = 2;
      this.label4.Text = "End Angle [Deg]";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(11, 83);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(104, 12);
      this.label3.TabIndex = 1;
      this.label3.Text = "Start Angle [Deg]";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 26);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(82, 12);
      this.label2.TabIndex = 0;
      this.label2.Text = "Average RPM";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.textBox);
      this.groupBox2.Location = new System.Drawing.Point(233, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(1018, 200);
      this.groupBox2.TabIndex = 14;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Log / Raw Packet";
      // 
      // textBox
      // 
      this.textBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox.Location = new System.Drawing.Point(6, 20);
      this.textBox.Multiline = true;
      this.textBox.Name = "textBox";
      this.textBox.Size = new System.Drawing.Size(1006, 167);
      this.textBox.TabIndex = 9;
      // 
      // textBox_avg_rpm
      // 
      this.textBox_avg_rpm.Location = new System.Drawing.Point(97, 23);
      this.textBox_avg_rpm.Name = "textBox_avg_rpm";
      this.textBox_avg_rpm.Size = new System.Drawing.Size(87, 21);
      this.textBox_avg_rpm.TabIndex = 10;
      // 
      // textBox_avg_pitch
      // 
      this.textBox_avg_pitch.Location = new System.Drawing.Point(97, 50);
      this.textBox_avg_pitch.Name = "textBox_avg_pitch";
      this.textBox_avg_pitch.Size = new System.Drawing.Size(87, 21);
      this.textBox_avg_pitch.TabIndex = 16;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(11, 53);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(83, 12);
      this.label8.TabIndex = 15;
      this.label8.Text = "Average Pitch";
      // 
      // pictureBox_passfail
      // 
      this.pictureBox_passfail.Location = new System.Drawing.Point(439, 218);
      this.pictureBox_passfail.Name = "pictureBox_passfail";
      this.pictureBox_passfail.Size = new System.Drawing.Size(84, 84);
      this.pictureBox_passfail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox_passfail.TabIndex = 19;
      this.pictureBox_passfail.TabStop = false;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.textBox_avg_pitch);
      this.groupBox3.Controls.Add(this.label2);
      this.groupBox3.Controls.Add(this.textBox_avg_rpm);
      this.groupBox3.Controls.Add(this.label8);
      this.groupBox3.Location = new System.Drawing.Point(233, 218);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(200, 84);
      this.groupBox3.TabIndex = 20;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Average Data";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1263, 313);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.pictureBox_passfail);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button_open);
      this.Controls.Add(this.serialComboBox);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "TurtleBot3 LD08 Tester";
      //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passfail)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox serialComboBox;
    private System.Windows.Forms.Button button_open;
    private System.IO.Ports.SerialPort serialPort1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBox_time;
    private System.Windows.Forms.TextBox textBox_end_angle;
    private System.Windows.Forms.TextBox textBox_start_angle;
    private System.Windows.Forms.TextBox textBox_rpm;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox_data_length;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBox_angle_gap;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox textBox;
    private System.Windows.Forms.TextBox textBox_avg_rpm;
    private System.Windows.Forms.TextBox textBox_avg_pitch;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.PictureBox pictureBox_passfail;
    private System.Windows.Forms.GroupBox groupBox3;
  }
}


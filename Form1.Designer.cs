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
      this.button_close = new System.Windows.Forms.Button();
      this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBox_time_gap = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "시리얼 포트";
      // 
      // serialComboBox
      // 
      this.serialComboBox.FormattingEnabled = true;
      this.serialComboBox.Location = new System.Drawing.Point(100, 6);
      this.serialComboBox.Name = "serialComboBox";
      this.serialComboBox.Size = new System.Drawing.Size(140, 20);
      this.serialComboBox.TabIndex = 1;
      // 
      // button_open
      // 
      this.button_open.Location = new System.Drawing.Point(100, 58);
      this.button_open.Name = "button_open";
      this.button_open.Size = new System.Drawing.Size(127, 23);
      this.button_open.TabIndex = 3;
      this.button_open.Text = "포트 열기 [Enter]";
      this.button_open.UseVisualStyleBackColor = true;
      this.button_open.Click += new System.EventHandler(this.button_open_Click);
      // 
      // button_close
      // 
      this.button_close.Location = new System.Drawing.Point(100, 96);
      this.button_close.Name = "button_close";
      this.button_close.Size = new System.Drawing.Size(127, 23);
      this.button_close.TabIndex = 4;
      this.button_close.Text = "포트 닫기 [ESC]";
      this.button_close.UseVisualStyleBackColor = true;
      this.button_close.Click += new System.EventHandler(this.button_close_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.textBox_time_gap);
      this.groupBox1.Controls.Add(this.label8);
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
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(14, 155);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(260, 242);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "LDS RAW Data";
      // 
      // textBox_time_gap
      // 
      this.textBox_time_gap.Location = new System.Drawing.Point(86, 204);
      this.textBox_time_gap.Name = "textBox_time_gap";
      this.textBox_time_gap.Size = new System.Drawing.Size(140, 21);
      this.textBox_time_gap.TabIndex = 13;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(19, 213);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(61, 12);
      this.label8.TabIndex = 12;
      this.label8.Text = "Time Gap";
      // 
      // textBox_angle_gap
      // 
      this.textBox_angle_gap.Location = new System.Drawing.Point(86, 177);
      this.textBox_angle_gap.Name = "textBox_angle_gap";
      this.textBox_angle_gap.Size = new System.Drawing.Size(140, 21);
      this.textBox_angle_gap.TabIndex = 11;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(16, 186);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(64, 12);
      this.label7.TabIndex = 10;
      this.label7.Text = "Angle Gap";
      // 
      // textBox_data_length
      // 
      this.textBox_data_length.Location = new System.Drawing.Point(86, 20);
      this.textBox_data_length.Name = "textBox_data_length";
      this.textBox_data_length.Size = new System.Drawing.Size(140, 21);
      this.textBox_data_length.TabIndex = 9;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(8, 29);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(72, 12);
      this.label6.TabIndex = 8;
      this.label6.Text = "Data Length";
      // 
      // textBox_time
      // 
      this.textBox_time.Location = new System.Drawing.Point(86, 150);
      this.textBox_time.Name = "textBox_time";
      this.textBox_time.Size = new System.Drawing.Size(140, 21);
      this.textBox_time.TabIndex = 7;
      // 
      // textBox_end_angle
      // 
      this.textBox_end_angle.Location = new System.Drawing.Point(86, 117);
      this.textBox_end_angle.Name = "textBox_end_angle";
      this.textBox_end_angle.Size = new System.Drawing.Size(140, 21);
      this.textBox_end_angle.TabIndex = 6;
      // 
      // textBox_start_angle
      // 
      this.textBox_start_angle.Location = new System.Drawing.Point(86, 84);
      this.textBox_start_angle.Name = "textBox_start_angle";
      this.textBox_start_angle.Size = new System.Drawing.Size(140, 21);
      this.textBox_start_angle.TabIndex = 5;
      // 
      // textBox_rpm
      // 
      this.textBox_rpm.Location = new System.Drawing.Point(86, 51);
      this.textBox_rpm.Name = "textBox_rpm";
      this.textBox_rpm.Size = new System.Drawing.Size(140, 21);
      this.textBox_rpm.TabIndex = 4;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(46, 159);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(34, 12);
      this.label5.TabIndex = 3;
      this.label5.Text = "Time";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(17, 126);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 12);
      this.label4.TabIndex = 2;
      this.label4.Text = "End Angle";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 93);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 12);
      this.label3.TabIndex = 1;
      this.label3.Text = "Start Angle";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(48, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 12);
      this.label2.TabIndex = 0;
      this.label2.Text = "RPM";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.textBox);
      this.groupBox2.Location = new System.Drawing.Point(280, 239);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(423, 158);
      this.groupBox2.TabIndex = 14;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Status Message";
      // 
      // textBox
      // 
      this.textBox.Location = new System.Drawing.Point(16, 27);
      this.textBox.Multiline = true;
      this.textBox.Name = "textBox";
      this.textBox.Size = new System.Drawing.Size(388, 114);
      this.textBox.TabIndex = 15;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(280, 9);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(423, 218);
      this.pictureBox1.TabIndex = 15;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(718, 409);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button_close);
      this.Controls.Add(this.button_open);
      this.Controls.Add(this.serialComboBox);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox serialComboBox;
    private System.Windows.Forms.Button button_open;
    private System.Windows.Forms.Button button_close;
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
    private System.Windows.Forms.TextBox textBox_time_gap;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBox_angle_gap;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox textBox;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}


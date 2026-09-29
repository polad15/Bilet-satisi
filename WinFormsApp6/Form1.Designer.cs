namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1367, 106);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(634, 37);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 2;
            label10.Text = "BMU trevel";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1087, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(234, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(46, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button4
            // 
            button4.Location = new Point(397, 46);
            button4.Name = "button4";
            button4.Size = new Size(39, 93);
            button4.TabIndex = 10;
            button4.Text = "<\r\n\r\n\r\n>\r\n";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(201, 235);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(122, 27);
            maskedTextBox2.TabIndex = 9;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(198, 173);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            comboBox3.Location = new Point(198, 286);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(122, 28);
            comboBox3.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Baki", "Izmir", "Paris", "Madrid", "London" });
            comboBox2.Location = new Point(201, 111);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(122, 28);
            comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Baki", "Izmir", "Paris", "Madrid", "London" });
            comboBox1.Location = new Point(201, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(122, 28);
            comboBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 294);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 4;
            label5.Text = "Yer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 242);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 3;
            label4.Text = "Saat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 180);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Tarix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 119);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Haraya";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 46);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "haraya";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 224, 192);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(858, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(435, 345);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button3
            // 
            button3.Location = new Point(192, 294);
            button3.Name = "button3";
            button3.Size = new Size(125, 29);
            button3.TabIndex = 8;
            button3.Text = "bilet al";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(192, 177);
            maskedTextBox3.Mask = "(994) 000-00-00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(125, 27);
            maskedTextBox3.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 242);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 3;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 180);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 2;
            label8.Text = "Telefon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 119);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 1;
            label7.Text = "FIN kod";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 61);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 0;
            label6.Text = "Ad ve Soyad";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(255, 255, 128);
            richTextBox1.Location = new Point(46, 517);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1247, 102);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(46, 651);
            button1.Name = "button1";
            button1.Size = new Size(135, 45);
            button1.TabIndex = 4;
            button1.Text = "Siyahidan sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1130, 651);
            button2.Name = "button2";
            button2.Size = new Size(163, 46);
            button2.TabIndex = 5;
            button2.Text = "Programdan cixin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1379, 729);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Label label10;
    }
}

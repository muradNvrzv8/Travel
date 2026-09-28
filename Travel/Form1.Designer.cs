namespace Travel
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            comboBox3 = new ComboBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 81);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 10);
            label1.Name = "label1";
            label1.Size = new Size(312, 65);
            label1.TabIndex = 1;
            label1.Text = "BMU TRAVEL";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bus;
            pictureBox2.Location = new Point(639, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(162, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 279);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Marshurut";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            comboBox3.Location = new Point(89, 233);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(141, 31);
            comboBox3.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(89, 181);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(141, 30);
            maskedTextBox2.TabIndex = 9;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(89, 133);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(141, 30);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Baki", "Gence", "Goranboy", "Tovuz", "Qusar" });
            comboBox2.Location = new Point(89, 85);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(141, 31);
            comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Baki", "Gence", "Goranboy", "Tovuz", "Qusar" });
            comboBox1.Location = new Point(89, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 31);
            comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(261, 22);
            button1.Name = "button1";
            button1.Size = new Size(52, 98);
            button1.TabIndex = 5;
            button1.Text = "<\r\n>\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 229);
            label6.Name = "label6";
            label6.Size = new Size(41, 22);
            label6.TabIndex = 4;
            label6.Text = "Yer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 182);
            label5.Name = "label5";
            label5.Size = new Size(51, 22);
            label5.TabIndex = 3;
            label5.Text = "Saat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 134);
            label4.Name = "label4";
            label4.Size = new Size(57, 22);
            label4.TabIndex = 2;
            label4.Text = "Tarix";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 85);
            label3.Name = "label3";
            label3.Size = new Size(75, 22);
            label3.TabIndex = 1;
            label3.Text = "Haraya";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 0;
            label2.Text = "Hardan";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkGray;
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(398, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 279);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sernisin melumatlari";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 30);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 30);
            textBox1.TabIndex = 11;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(179, 84);
            maskedTextBox3.Mask = ">AAAAAAAA";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(166, 30);
            maskedTextBox3.TabIndex = 9;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(179, 133);
            maskedTextBox4.Mask = "(+994)00-000-00-00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(166, 30);
            maskedTextBox4.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(116, 229);
            button2.Name = "button2";
            button2.Size = new Size(169, 36);
            button2.TabIndex = 5;
            button2.Text = "Bileti Al";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 182);
            label8.Name = "label8";
            label8.Size = new Size(61, 22);
            label8.TabIndex = 3;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(37, 134);
            label9.Name = "label9";
            label9.Size = new Size(79, 22);
            label9.TabIndex = 2;
            label9.Text = "Telefon";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(37, 84);
            label10.Name = "label10";
            label10.Size = new Size(80, 22);
            label10.TabIndex = 1;
            label10.Text = "FIN kod";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(37, 35);
            label11.Name = "label11";
            label11.Size = new Size(126, 22);
            label11.TabIndex = 0;
            label11.Text = "Ad ve Soyad";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { " " });
            listBox1.Location = new Point(112, 395);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(560, 116);
            listBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 420);
            button3.Name = "button3";
            button3.Size = new Size(94, 50);
            button3.TabIndex = 13;
            button3.Text = "Siyahidan Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(693, 420);
            button4.Name = "button4";
            button4.Size = new Size(94, 50);
            button4.TabIndex = 14;
            button4.Text = "Proqramdan cixis";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(799, 515);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Algerian", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(192, 0, 0);
            Name = "Form1";
            Text = "Form1";
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
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private Button button2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
    }
}

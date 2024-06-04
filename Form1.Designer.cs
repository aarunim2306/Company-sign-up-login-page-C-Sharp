namespace GUIDEMO
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            radioButton3 = new RadioButton();
            checkBox1 = new CheckBox();
            label4 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            linkLabel1 = new LinkLabel();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(686, 442);
            button1.Name = "button1";
            button1.Size = new Size(91, 49);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(408, 442);
            button2.Name = "button2";
            button2.Size = new Size(85, 49);
            button2.TabIndex = 1;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(594, 243);
            label1.Name = "label1";
            label1.Size = new Size(95, 26);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(594, 284);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(753, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(753, 283);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 23);
            textBox2.TabIndex = 6;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(6, 9);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 22);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(89, 9);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 22);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(594, 329);
            label3.Name = "label3";
            label3.Size = new Size(63, 18);
            label3.TabIndex = 9;
            label3.Text = "Gender";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(189, 9);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(63, 22);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(458, 417);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(294, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "I Understand and Accept the Terms and Conditions";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(594, 364);
            label4.Name = "label4";
            label4.Size = new Size(134, 18);
            label4.TabIndex = 12;
            label4.Text = "Payment Method";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(6, 12);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(139, 22);
            radioButton4.TabIndex = 13;
            radioButton4.TabStop = true;
            radioButton4.Text = "Credit/Debit Card";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton5.Location = new Point(153, 12);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(106, 22);
            radioButton5.TabIndex = 14;
            radioButton5.TabStop = true;
            radioButton5.Text = "Net Banking";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton6.Location = new Point(274, 12);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(72, 22);
            radioButton6.TabIndex = 15;
            radioButton6.TabStop = true;
            radioButton6.Text = "PayPal";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(753, 318);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 34);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new Point(753, 355);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(348, 39);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(348, 49);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(418, 49);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up Page";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.Control;
            progressBar1.Location = new Point(472, 80);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(168, 18);
            progressBar1.TabIndex = 19;
            progressBar1.Click += progressBar1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(514, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 87);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(549, 442);
            button3.Name = "button3";
            button3.Size = new Size(91, 49);
            button3.TabIndex = 21;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(97, 243);
            label5.Name = "label5";
            label5.Size = new Size(95, 26);
            label5.TabIndex = 22;
            label5.Text = "FirstName";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(97, 284);
            label6.Name = "label6";
            label6.Size = new Size(95, 26);
            label6.TabIndex = 23;
            label6.Text = "LastName";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(97, 323);
            label7.Name = "label7";
            label7.Size = new Size(95, 26);
            label7.TabIndex = 24;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(97, 363);
            label8.Name = "label8";
            label8.Size = new Size(95, 26);
            label8.TabIndex = 25;
            label8.Text = "Phone";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(248, 243);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(276, 23);
            textBox3.TabIndex = 26;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(248, 359);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(276, 23);
            textBox4.TabIndex = 27;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(248, 323);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(276, 23);
            textBox5.TabIndex = 28;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(248, 284);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(276, 23);
            textBox6.TabIndex = 29;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 637);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Sign Up Page";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label3;
        private RadioButton radioButton3;
        private CheckBox checkBox1;
        private Label label4;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private LinkLabel linkLabel1;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}

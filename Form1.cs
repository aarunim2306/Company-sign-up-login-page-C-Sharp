using System.Reflection;

namespace GUIDEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult dr = MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }

            else if (dr == DialogResult.No)
            {
                Show();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Validate();
            progressBar1.Increment(100);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Validate();
            progressBar1.Increment(10);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Validate();
            progressBar1.Increment(10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account is created!", "Congratulations");
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Validate();
            progressBar1.Increment(1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Validate();
            progressBar1.Increment(1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Validate();
            progressBar1.Increment(5);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            Validate();
            progressBar1.Increment(5);
        }

        private void Validate()
        {
            if (checkBox1.Checked && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked) && (radioButton4.Checked || radioButton5.Checked || radioButton6.Checked))
            {
                button2.Enabled = true;
            }

            else
            {
                button2.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Validate();
            progressBar1.Increment(10);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Validate();
            progressBar1.Increment(10);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Validate();
            progressBar1.Increment(10);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar()
        {
            this.progressBar1.Increment(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDEMO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void Validate()
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                button2.Enabled = true;
            }

            else
            {
                button2.Enabled = false;
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully logged in!", "Congratulations");
            this.Close();
            Form4 form4 = new Form4();
            form4.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }
    }
}

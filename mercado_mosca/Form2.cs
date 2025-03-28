using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mercado_mosca
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void ButtonEnableOff()
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0) bt1.Enabled = true;
            else bt1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ButtonEnableOff();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ButtonEnableOff();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ButtonEnableOff();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Hide();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

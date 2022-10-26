using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _作業02_Exec2_TextBox_Q2_21謝孟勳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string birth = textBox1.Text;

            DateTime datebirth = Convert.ToDateTime(textBox1.Text);
            DateTime today = DateTime.Today;

            if (datebirth > today)
            {
                MessageBox.Show("生日不可在今天之後");
            }
            else
            {
                MessageBox.Show($"您的生日為{birth}");
            }


        }
    }
}

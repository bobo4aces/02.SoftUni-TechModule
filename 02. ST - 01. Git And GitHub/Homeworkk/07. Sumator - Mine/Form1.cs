using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07.Sumator___Mine
{
    public partial class sumator : Form
    {
        public sumator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = double.Parse(this.number1.Text);
                var num2 = double.Parse(this.number2.Text);
                var sum = num1 + num2;
                total.Text = sum.ToString();
            }
            catch (Exception)
            {
                total.Text = "error";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

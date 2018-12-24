using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = double.Parse(textBox1.Text);
                var num2 = double.Parse(textBox2.Text);

                var result = num1 + num2;
                textBoxResult.Text = result.ToString();
            }
            catch
            {
                textBoxResult.Text = "error";
            }
        }
    }
}

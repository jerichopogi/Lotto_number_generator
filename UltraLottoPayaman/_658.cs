using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraLottoPayaman
{
    public partial class _658 : Form
    {
        Random rand1 = new Random();

        private void randomize()
        {
            int num1 = rand1.Next(1, 58);
            int num2 = rand1.Next(1, 58);
            int num3 = rand1.Next(1, 58);
            int num4 = rand1.Next(1, 58);
            int num5 = rand1.Next(1, 58);
            int num6 = rand1.Next(1, 58);

            label1.Text = num1.ToString();
            label2.Text = num2.ToString();
            label3.Text = num3.ToString();
            label4.Text = num4.ToString();
            label5.Text = num5.ToString();
            label6.Text = num6.ToString();
        }
        public _658()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            randomize();
        }
    }
}

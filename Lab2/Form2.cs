using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            double n;

            if (!double.TryParse(textBox1.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture, out a) ||
                !double.TryParse(textBox2.Text.Trim(), NumberStyles.Any, CultureInfo.CurrentCulture, out b) ||
                !double.TryParse(textBox3.Text.Trim(), out n) || n <= 0)
            {
                MessageBox.Show("Помилка введення! Введіть коректні значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (a < 0 && b > 0)
            {
                MessageBox.Show("Інтеграл не визначений на інтервалі через x=0!","Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double h = (b - a) / n;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double x = a + i * h + h / 2; // середина прямокутника
                double y = Math.Sin(x) - 1 / x;
                sum += y;
            }

            double integral = sum * h;
            textBox4.Text = integral.ToString("F6");
        }

    }
}

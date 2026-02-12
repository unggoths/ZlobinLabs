using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string text = textBox1.Text;

           
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Будь ласка, введіть числа через кому.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            string[] parts = text.Split(',');

            
            List<double> numbers = new List<double>();

            
            for (int i = 0; i < parts.Length; i++)
            {
                
                
                if (double.TryParse(parts[i].Trim(), out double number))
                {
                    numbers.Add(number);
                }
                else
                {
                   
                    if (!string.IsNullOrWhiteSpace(parts[i]))
                    {
                        MessageBox.Show("Будь ласка, введіть коректне число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (numbers.Count == 0)
            {
                MessageBox.Show("Не вдалося отримати жодного числа.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            double maxVal = numbers[0];
            int maxIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > maxVal)
                {
                    maxVal = numbers[i];
                    maxIndex = i;
                }
            }

            
            textBox2.Text = maxVal.ToString(); 
            textBox3.Text = maxIndex.ToString(); 
        }
        
    }
}

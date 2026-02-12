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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string text = textBox1.Text;

            
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Будь ласка, введіть числа через кому.", "Помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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
                        MessageBox.Show($"Неможливо розпізнати число: '{parts[i]}'", "Помилка формату");
                        return;
                    }
                }
            }

            if (numbers.Count == 0)
            {
                MessageBox.Show("Не вдалося отримати жодного числа.", "Помилка");
                return;
            }

            
            double minVal = numbers[0];
            int minIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < minVal)
                {
                    minVal = numbers[i];
                    minIndex = i;
                }
            }

            
            textBox2.Text = minVal.ToString(); // Значення
            textBox3.Text = minIndex.ToString(); // Індекс
        }
    }
}

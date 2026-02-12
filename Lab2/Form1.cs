using System.Globalization;

namespace Lab2
{
    public partial class TabulateFunc : Form
    {
        public TabulateFunc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, h;

            if (!double.TryParse(textBox4.Text.Trim(),
                    NumberStyles.Any,
                    CultureInfo.CurrentCulture,
                    out a) ||

                !double.TryParse(textBox5.Text.Trim(),
                    NumberStyles.Any,
                    CultureInfo.CurrentCulture,
                    out b) ||

                !double.TryParse(textBox6.Text.Trim(),
                    NumberStyles.Any,
                    CultureInfo.CurrentCulture,
                    out h))
            {
                MessageBox.Show("Помилка введення чисел!");
                return;
            }
            if (h == 0)
            {
                MessageBox.Show("Крок не може бути 0!");
                return;
            }

            // Очистити таблицю
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Створити колонки
            dataGridView1.Columns.Add("x", "x");
            dataGridView1.Columns.Add("y", "y");

            // Табулювання
            for (double x = a; x <= b; x += h)
            {
                if (x == 0)
                {
                    dataGridView1.Rows.Add(x, "undefined");
                    continue;
                }

                double y = Math.Sin(x) - 1 / x;
                dataGridView1.Rows.Add(x, y);
            }
        }
    }
}

using System;
using System.Windows.Forms;
using OOP_labs.Shapes;

namespace Interface
{
    public partial class AddSquare : Form
    {
        private double side;
        public AddSquare()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            side = Convert.ToDouble(textBox1.Text);
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            try
            {
                var square = new Square(side);
                ((FormShapesList) this.Tag).ListBox1.Items.Add(square);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно добавить фигуру. Проверьте правильность данных.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
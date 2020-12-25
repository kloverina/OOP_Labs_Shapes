using System;
using System.Windows.Forms;
using OOP_labs.Shapes;

namespace Interface
{
    public partial class AddCircle : Form
    {
        private double radius;
        public AddCircle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                radius = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                textBox1.Clear();
                MessageBox.Show("Неверный формат данных. Формат данных для этого поля: double.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            try
            {
                var circle = new Circle(radius);
                ((FormShapesList) this.Tag).ListBox1.Items.Add(circle);
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
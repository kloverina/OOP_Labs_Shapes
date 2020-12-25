using System;
using System.Windows.Forms;
using OOP_labs.Shapes;

namespace Interface
{
    public partial class AddTriangle : Form
    {
        private double sideA;
        private double sideB;
        private double sideC;
        

        public AddTriangle()
        {
            InitializeComponent();
        }

       

        private void textBox_A_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_C_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                sideA = Convert.ToDouble(textBox_A.Text);
                sideB = Convert.ToDouble(textBox_B.Text);
                sideC = Convert.ToDouble(textBox_C.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат данных. Формат данных для этого поля: double.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            try
            {
                var triangle = new Triangle(sideA, sideB, sideC);
                ((FormShapesList) this.Tag).ListBox1.Items.Add(triangle);
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
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OOP_labs.Shapes;

namespace Interface
{
    public partial class AddRectangle : Form

    {
        
        private double height;
        private double width;
        
        public AddRectangle()
        {
            InitializeComponent();
            
        }


        private void textBox_Height_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox_Width_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private void button_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                width = Convert.ToDouble(textBox_Width.Text);
                height = Convert.ToDouble(textBox_Height.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат данных. Формат данных для этого поля: double.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            try
            {
                var rectangle = new Rectangle(width, height);
                ((FormShapesList) this.Tag).ListBox1.Items.Add(rectangle);
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
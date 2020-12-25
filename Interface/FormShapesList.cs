using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OOP_labs.Shapes;

namespace Interface
{
    public partial class FormShapesList : Form
    {
        public List<IShape> FiguresList = new List<IShape>();
    
        private AddRectangle AddRectangle;
        private AddSquare AddSquare;
        private AddCircle AddCircle;
        private AddTriangle AddTriangle;

        public ListBox ListBox1
        {
            get => listBox1;
            set => listBox1 = value;
        }

        public FormShapesList(List<IShape> listOfFigures)
        {
            InitializeComponent();
            this.FiguresList = listOfFigures;
            foreach (var figure in listOfFigures)
            {
                listBox1.Items.Add(figure);
            }
        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }


        private void Button_DeleteFigure_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                MessageBox.Show("Невозможно удалить фигуру так как список пуст.", $"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if(listBox1.SelectedItem == null)
                MessageBox.Show("Не выбрана фигура для удаления.", $"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void Button_AddRect_Click(object sender, EventArgs e)
        {
            AddRectangle = new AddRectangle();
            AddRectangle.Tag = this;
            AddRectangle.Show();
        }

        private void button_AddSquare_Click(object sender, EventArgs e)
        {
            AddSquare = new AddSquare();
            AddSquare.Tag = this;
            AddSquare.Show();
        }

        private void button_AddCircle_Click(object sender, EventArgs e)
        {
            AddCircle = new AddCircle();
            AddCircle.Tag = this;
            AddCircle.Show();
        }

        private void Button_AddTri_Click(object sender, EventArgs e)
        {
            AddTriangle = new AddTriangle();
            AddTriangle.Tag = this;
            AddTriangle.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OOP.JsonParser;
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

        private void button_SaveFile_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.Filter = "Json-files (*.json)| *.json";
                 
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            FiguresList.Clear();
            foreach (var t in listBox1.Items)
            {
                FiguresList.Add((IShape) t);
            }

            string fileName = saveFileDialog1.FileName.Replace(@"\", @"/");
          
            JsonParser.Serialize(FiguresList, fileName, true);
            Close();
        }


        private void Button_Up_Click(object sender, EventArgs e)
        {
            if(ListBox1.SelectedIndex == -1)
                MessageBox.Show("Не выбрано ни одной фигуры!", $"Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (ListBox1.SelectedIndex == 0)
                MessageBox.Show("Операция невозможна. Выбранная фигура и так является первой в списке.", $"Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
               
                var index = ListBox1.SelectedIndex;
                var value = listBox1.Items[index];
                object[] ar=new object[listBox1.Items.Count];
                listBox1.Items.CopyTo(ar,0);
               
                ar[index] = ar[index-1];
                ar[index-1] = value;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(ar);

       
            }


        }

        private void Button_Down_Click(object sender, EventArgs e)
        {
            if(ListBox1.SelectedIndex == -1)
                MessageBox.Show("Не выбрано ни одной фигуры!", $"Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (ListBox1.SelectedIndex == ListBox1.Items.Count)
                MessageBox.Show("Операция невозможна. Выбранная фигура и так является последней в списке.", $"Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
               
                var index = ListBox1.SelectedIndex;
                var value = listBox1.Items[index];
                object[] ar=new object[listBox1.Items.Count];
                listBox1.Items.CopyTo(ar,0);
               
                ar[index] = ar[index+1];
                ar[index+1] = value;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(ar);

       
            }
        }
    }
}
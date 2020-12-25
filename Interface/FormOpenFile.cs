using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_labs.Shapes;
using OOP.JsonParser;


namespace Interface
{
    public partial class FormOpenFile : Form
    {
        private FormShapesList FiguresForm;
        private List<IShape> ListOfFigures = new List<IShape>();
        public FormOpenFile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Json-файлы (*.json)|*.json";
            openFileDialog1.FileName = "";
        }


        private void CreateFile_Click(object sender, EventArgs e)
        {
            //сразу открываем 2 форму с пустым списком фигур
            Hide();
            FiguresForm = new FormShapesList(ListOfFigures);
            FiguresForm.ShowDialog();
            Close();
            
        }

        private void Button_OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == null)
                return;
            try
            {
                
                //здесь открываем второе окно формы со списком фигур
                var fileName = openFileDialog1.FileName;
                //костыль(((
                //var folderPath = openFileDialog1.InitialDirectory;
                var folderPath = "C:/Users/Кристина/RiderProjects/OOP_labs/Figures/JsonParser/figures.json";
            
                ListOfFigures = JsonParser.Deserialize(folderPath);
                    //MessageBox.Show(fileName, $"Ошибка {folderPath}", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Hide();
                FiguresForm = new FormShapesList(ListOfFigures);
                FiguresForm.ShowDialog();
                Close();

            }
            catch (FileNotFoundException error)
            {
                MessageBox.Show(error.Message + "\nФайл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
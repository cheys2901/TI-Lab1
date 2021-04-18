using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmMain : Form
    {

        private string pathToFileOpen = "";
        private string pathToKey = "";
        private string pathToFileSave = "";

        public frmMain()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.FileName = "";
            cmbBoxType.SelectedIndex = 0;
        }


        private string OpenFile()
        {
            string dirPath = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Выберите файл с исходным текстом";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    dirPath = openFileDialog1.FileName;
                }
            return dirPath;
        }

        private string SaveFile()
        {
            string dirPath = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Выберите файл для сохранения";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dirPath = openFileDialog1.FileName;
            }
            return dirPath;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pathToFileOpen = OpenFile();
            fileNameOpen.Text = pathToFileOpen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!choise.Checked)
            {
                pathToKey = OpenFile();
                nameKey.Text = pathToKey;
            }
            else
            {
                pathToKey = SaveFile();
                nameKey.Text = pathToKey;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pathToFileSave = SaveFile();
            nameSave.Text = pathToFileSave;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (choise.Checked)
            {
                switch (cmbBoxType.SelectedIndex)
                {
                    case 0:
                        Railway railway = new Railway(pathToFileOpen, pathToFileSave, pathToKey);
                        railway.EncryptionFile();
                        break;
                    case 1:
                        Collumn collumn = new Collumn(pathToFileOpen, pathToFileSave, pathToKey);
                        collumn.EncryptionFile();
                        break;
                    case 2:
                        LatticeCardano latticeCardano = new LatticeCardano(trackBar1.Value, pathToFileOpen, pathToFileSave, pathToKey);
                        latticeCardano.InitCart(Takematrix());
                        latticeCardano.EncryptionFile();
                        latticeCardano.WriteKey();
                        break;
                    case 3:
                        Сaesar caesar = new Сaesar(pathToFileOpen, pathToFileSave, pathToKey);
                        caesar.EncryptionFile();
                        break;
                }
            }
            else
            {
                switch (cmbBoxType.SelectedIndex)
                {
                    case 0:
                        Railway rail = new Railway(pathToFileOpen, pathToFileSave, pathToKey);
                        rail.DecipherFile();
                        break;
                    case 1:
                        Collumn collumn = new Collumn(pathToFileOpen, pathToFileSave, pathToKey);
                        collumn.DecipherFile();
                        break;
                    case 2:
                        LatticeCardano latticeCardano = new LatticeCardano(pathToFileOpen, pathToFileSave, pathToKey);
                        latticeCardano.ReadKey();
                        latticeCardano.DecipherFile();
                        break;
                    case 3:
                        Сaesar caesar = new Сaesar(pathToFileOpen, pathToFileSave, pathToKey);
                        caesar.DecipherFile();
                        break;
                        break;
                }
            }
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            valueSize.Text = trackBar1.Value.ToString();
            ChangeGrid();
        }


        private void ChangeGrid()
        {
            dataGridView1.ColumnCount = trackBar1.Value;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.RowCount = trackBar1.Value;
        }

        private int[,] Takematrix()
        {
            var res = new int[trackBar1.Value, trackBar1.Value];
            for(int i=0; i < trackBar1.Value; i++)
            {
                for(int j = 0; j < trackBar1.Value; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value!=null)
                    {
                        res[i, j] = 1;
                    }
                }
            }
            return res;
        }
    }
}

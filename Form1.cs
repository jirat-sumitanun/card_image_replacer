using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace illusion_image_replacer
{
    public partial class Form1 : Form
    {
        public string replaceImagePath;
        public string cardImagePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (errorHandler())
            {
                Console.WriteLine("start saving");
                string filename = this.filenameTextBox.Text.EndsWith(".png", StringComparison.CurrentCultureIgnoreCase) ? this.filenameTextBox.Text : this.filenameTextBox.Text + ".png";
                string savePath = Path.Combine(Path.GetDirectoryName(cardImagePath), filename);
                illusion_filter_class.saveNewCard(this.cardImagePath,this.replaceImagePath, savePath);
            }

        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            if (errorHandler())
            {
                this.saveFileDialog1.InitialDirectory = Path.GetDirectoryName(cardImagePath);
                this.saveFileDialog1.FileName = this.filenameTextBox.Text;
                
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Console.WriteLine(this.saveFileDialog1.FileName);
                    Console.WriteLine("save as Card");
                    illusion_filter_class.saveNewCard(cardImagePath, replaceImagePath, this.saveFileDialog1.FileName);
                }
                
            }
        }

        private void cardImageBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void cardImageBox_DragDrop(object sender, DragEventArgs e)
        {
            String[] droppedItem = (String[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var item in droppedItem)
            {
                if (Path.GetExtension(item) == ".png")
                {
                    this.cardImageBox.Image = Image.FromFile(item);
                    this.cardImagePath = item;
                    this.filenameTextBox.Text = "new_" + Path.GetFileNameWithoutExtension(item);
                }
                else
                {
                    MessageBox.Show("only png", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void replaceImageBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void replaceImageBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] accept_ext = { ".png", ".jpg", ".jpeg", ".bmp", ".jiff" };
            String[] droppedItem = (String[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var item in droppedItem)
            {
                for (int i = 0; i < accept_ext.Length; i++)
                {
                    if(Path.GetExtension(item) == accept_ext[i]){
                    this.replaceImageBox.Image = Image.FromFile(item);
                    this.replaceImagePath = item;
                }
                }

            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.cardImageBox.Image = null;
            this.replaceImageBox.Image = null;
            this.filenameTextBox.Text = "";
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if(this.cardImageBox.Image == null)
            {
                MessageBox.Show("import card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                illusion_filter_class.extractImage(this.cardImagePath);
            }
        }

        private bool errorHandler()
        {
            if (this.cardImageBox.Image == null)
            {
                MessageBox.Show("import card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.replaceImageBox.Image == null)
            {
                MessageBox.Show("import replace image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            
        }
    }
}

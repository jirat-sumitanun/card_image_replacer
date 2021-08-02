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
                this.statusLabel.Text = "";
                string filename = this.filenameTextBox.Text.EndsWith(".png", StringComparison.CurrentCultureIgnoreCase) ? this.filenameTextBox.Text : this.filenameTextBox.Text + ".png";
                string savePath = Path.Combine(Path.GetDirectoryName(cardImagePath), filename);
                if (File.Exists(savePath))
                {
                    customDialog d = new customDialog();
                    d.ShowDialog();
                    if (d.userChoice == "overWrite")
                    {
                        File.Delete(savePath);
                        startTask(this.cardImagePath, this.replaceImagePath, savePath);
                    }
                    else if (d.userChoice == "duplicate")
                    {
                        savePath = illusion_utils_class.createNewFilename(savePath);
                        startTask(this.cardImagePath, this.replaceImagePath, savePath);
                    }
                }
                else
                {
                    startTask(this.cardImagePath, this.replaceImagePath, savePath);
                }
            }

        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            if (errorHandler())
            {
                this.statusLabel.Text = "";
                this.saveFileDialog1.InitialDirectory = Path.GetDirectoryName(cardImagePath);
                this.saveFileDialog1.FileName = this.filenameTextBox.Text;
                
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    startTask(cardImagePath, replaceImagePath, this.saveFileDialog1.FileName);

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
                if (illusion_filter_class.illusion_filter(item) == "true")
                {
                    this.statusLabel.Text = "";
                    this.cardImageBox.Image = Image.FromFile(item);
                    this.cardImagePath = item;
                    this.filenameTextBox.Text = "new_" + Path.GetFileNameWithoutExtension(item);
                }
                else
                {
                    MessageBox.Show(illusion_filter_class.illusion_filter(item), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void replaceImageBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void replaceImageBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] accept_ext = { ".png", ".jpg", ".jpeg", ".jiff" };
            String[] droppedItem = (String[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var item in droppedItem)
            {
                for (int i = 0; i < accept_ext.Length; i++)
                {
                    
                    if (Path.GetExtension(item) == accept_ext[i]){
                        this.statusLabel.Text = "";
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
            this.statusLabel.Text = "";
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if(this.cardImageBox.Image == null)
            {
                MessageBox.Show("import card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                illusion_utils_class.extractImage(this.cardImagePath);
                this.statusLabel.Text = "Exported";
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
            if(this.filenameTextBox.Text == "")
            {
                MessageBox.Show("please fill filename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            
        }
        private async void startTask(string cardImagePath,string replaceImagePath, string savePath)
        {
            await Task.Run(() => illusion_utils_class.createNewCard(cardImagePath, replaceImagePath, savePath));
            this.statusLabel.Text = "Finished";
        }

        private void selectCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            this.openFileDialog1.ShowDialog();
            if(illusion_filter_class.illusion_filter(this.openFileDialog1.FileName) == "true")
            {
                this.statusLabel.Text = "";
                if (this.openFileDialog1.FileName != "")
                {
                    this.cardImageBox.Image = Image.FromFile(this.openFileDialog1.FileName);
                    this.filenameTextBox.Text = "new_" + Path.GetFileNameWithoutExtension(this.openFileDialog1.FileName);
                    this.cardImagePath = this.openFileDialog1.FileName;
                }
            }
            else
            {
                MessageBox.Show(illusion_filter_class.illusion_filter(this.openFileDialog1.FileName), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void selectReplaceImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusLabel.Text = "";
            this.openFileDialog1.Filter = "Image file (*.png, *.jpg, *.jpeg, *.jiff)| *.png;*.jpg;*.jepg;*.jiff";
            this.openFileDialog1.ShowDialog();
            if (this.openFileDialog1.FileName != "")
            {
                this.replaceImageBox.Image = Image.FromFile(this.openFileDialog1.FileName);
                this.replaceImagePath = this.openFileDialog1.FileName;
            }

        }
    }
}

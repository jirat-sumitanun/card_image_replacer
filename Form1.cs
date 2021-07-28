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
            string savePath = Directory.GetCurrentDirectory();
        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {

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
                Console.WriteLine(item);
                this.cardImageBox.Image = Image.FromFile(item);
                this.cardImagePath = item;
                this.filenameTextBox.Text = "new_" + Path.GetFileNameWithoutExtension(item);
            }
        }

        private void replaceImageBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void replaceImageBox_DragDrop(object sender, DragEventArgs e)
        {
            String[] droppedItem = (String[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var item in droppedItem)
            {
                this.replaceImageBox.Image = Image.FromFile(item);
                this.replaceImagePath = item;
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

        }
    }
}

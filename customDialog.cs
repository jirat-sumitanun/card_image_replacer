using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace illusion_image_replacer
{
    public partial class customDialog : Form
    {
        public customDialog()
        {
            InitializeComponent();
        }
        public string userChoice { get; set; }

        private void overWriteBtn_Click(object sender, EventArgs e)
        {
            this.userChoice = "overWrite";
            this.Close();
        }

        private void addDuplicateBtn_Click(object sender, EventArgs e)
        {
            this.userChoice = "duplicate";
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.userChoice = "cancel";
            this.Close();
        }
    }
}

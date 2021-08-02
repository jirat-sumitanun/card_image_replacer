
namespace illusion_image_replacer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cardImageBox = new System.Windows.Forms.PictureBox();
            this.replaceImageBox = new System.Windows.Forms.PictureBox();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveAsBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.creditLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.selectCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectReplaceImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cardImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceImageBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardImageBox
            // 
            this.cardImageBox.AllowDrop = true;
            this.cardImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cardImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardImageBox.Location = new System.Drawing.Point(43, 60);
            this.cardImageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardImageBox.Name = "cardImageBox";
            this.cardImageBox.Size = new System.Drawing.Size(397, 361);
            this.cardImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardImageBox.TabIndex = 0;
            this.cardImageBox.TabStop = false;
            this.cardImageBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.cardImageBox_DragDrop);
            this.cardImageBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.cardImageBox_DragEnter);
            // 
            // replaceImageBox
            // 
            this.replaceImageBox.AllowDrop = true;
            this.replaceImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.replaceImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.replaceImageBox.Location = new System.Drawing.Point(548, 60);
            this.replaceImageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.replaceImageBox.Name = "replaceImageBox";
            this.replaceImageBox.Size = new System.Drawing.Size(397, 361);
            this.replaceImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.replaceImageBox.TabIndex = 1;
            this.replaceImageBox.TabStop = false;
            this.replaceImageBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.replaceImageBox_DragDrop);
            this.replaceImageBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.replaceImageBox_DragEnter);
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.AllowDrop = true;
            this.filenameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.filenameTextBox.Location = new System.Drawing.Point(100, 2);
            this.filenameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(314, 28);
            this.filenameTextBox.TabIndex = 2;
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.filenameLabel.Location = new System.Drawing.Point(2, 0);
            this.filenameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(94, 24);
            this.filenameLabel.TabIndex = 3;
            this.filenameLabel.Text = "Filename:";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.saveBtn.Location = new System.Drawing.Point(2, 2);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(86, 48);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.saveAsBtn.Location = new System.Drawing.Point(92, 2);
            this.saveAsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(99, 48);
            this.saveAsBtn.TabIndex = 5;
            this.saveAsBtn.Text = "SAVE AS";
            this.saveAsBtn.UseVisualStyleBackColor = true;
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.statusLabel.Location = new System.Drawing.Point(890, 457);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(149, 26);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "lorem impules";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(208, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(683, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Replace Image";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.clearBtn.Location = new System.Drawing.Point(291, 2);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(92, 48);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.exportBtn.Location = new System.Drawing.Point(195, 2);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(92, 48);
            this.exportBtn.TabIndex = 10;
            this.exportBtn.Text = "Export Image";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "PNG file |*.png";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save New Card";
            // 
            // creditLabel
            // 
            this.creditLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.creditLabel.AutoSize = true;
            this.creditLabel.Location = new System.Drawing.Point(902, 514);
            this.creditLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(89, 13);
            this.creditLabel.TabIndex = 11;
            this.creditLabel.Text = "created by Jirat.S";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.saveBtn);
            this.flowLayoutPanel1.Controls.Add(this.saveAsBtn);
            this.flowLayoutPanel1.Controls.Add(this.exportBtn);
            this.flowLayoutPanel1.Controls.Add(this.clearBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(494, 445);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(391, 54);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.filenameLabel);
            this.flowLayoutPanel2.Controls.Add(this.filenameTextBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(26, 455);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(423, 40);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(992, 27);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectCardToolStripMenuItem,
            this.selectReplaceImageToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(33, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // selectCardToolStripMenuItem
            // 
            this.selectCardToolStripMenuItem.Name = "selectCardToolStripMenuItem";
            this.selectCardToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.selectCardToolStripMenuItem.Text = "Select Card";
            this.selectCardToolStripMenuItem.Click += new System.EventHandler(this.selectCardToolStripMenuItem_Click);
            // 
            // selectReplaceImageToolStripMenuItem
            // 
            this.selectReplaceImageToolStripMenuItem.Name = "selectReplaceImageToolStripMenuItem";
            this.selectReplaceImageToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.selectReplaceImageToolStripMenuItem.Text = "Select Replace Image";
            this.selectReplaceImageToolStripMenuItem.Click += new System.EventHandler(this.selectReplaceImageToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PNG File | *.png";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Select Card";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 529);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.replaceImageBox);
            this.Controls.Add(this.cardImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Illusion Image Replacer";
            ((System.ComponentModel.ISupportInitialize)(this.cardImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceImageBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cardImageBox;
        private System.Windows.Forms.PictureBox replaceImageBox;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button saveAsBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem selectCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectReplaceImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


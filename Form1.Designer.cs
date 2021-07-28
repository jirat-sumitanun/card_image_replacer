
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
            ((System.ComponentModel.ISupportInitialize)(this.cardImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardImageBox
            // 
            this.cardImageBox.AllowDrop = true;
            this.cardImageBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cardImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardImageBox.Location = new System.Drawing.Point(56, 56);
            this.cardImageBox.Name = "cardImageBox";
            this.cardImageBox.Size = new System.Drawing.Size(529, 444);
            this.cardImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardImageBox.TabIndex = 0;
            this.cardImageBox.TabStop = false;
            this.cardImageBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.cardImageBox_DragDrop);
            this.cardImageBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.cardImageBox_DragEnter);
            // 
            // replaceImageBox
            // 
            this.replaceImageBox.AllowDrop = true;
            this.replaceImageBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.replaceImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.replaceImageBox.Location = new System.Drawing.Point(730, 56);
            this.replaceImageBox.Name = "replaceImageBox";
            this.replaceImageBox.Size = new System.Drawing.Size(529, 444);
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
            this.filenameTextBox.Location = new System.Drawing.Point(174, 531);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(398, 34);
            this.filenameTextBox.TabIndex = 2;
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.filenameLabel.Location = new System.Drawing.Point(38, 532);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(120, 29);
            this.filenameLabel.TabIndex = 3;
            this.filenameLabel.Text = "Filename:";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.saveBtn.Location = new System.Drawing.Point(638, 518);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(115, 59);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.saveAsBtn.Location = new System.Drawing.Point(768, 518);
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(132, 59);
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
            this.statusLabel.Location = new System.Drawing.Point(1186, 533);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(124, 32);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Finished";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(276, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(910, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Replace Image";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.clearBtn.Location = new System.Drawing.Point(1058, 519);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(122, 59);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.exportBtn.Location = new System.Drawing.Point(916, 519);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(122, 59);
            this.exportBtn.TabIndex = 10;
            this.exportBtn.Text = "Export Image";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "Image Files (*.png)|*.png";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save New Card";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 607);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.saveAsBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.filenameLabel);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.replaceImageBox);
            this.Controls.Add(this.cardImageBox);
            this.Name = "Form1";
            this.Text = "Illusion Image Replacer";
            ((System.ComponentModel.ISupportInitialize)(this.cardImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replaceImageBox)).EndInit();
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
    }
}



namespace illusion_image_replacer
{
    partial class customDialog
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.overWriteBtn = new System.Windows.Forms.Button();
            this.addDuplicateBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.customDialogWarningLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.overWriteBtn);
            this.flowLayoutPanel1.Controls.Add(this.addDuplicateBtn);
            this.flowLayoutPanel1.Controls.Add(this.cancelBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 54);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // overWriteBtn
            // 
            this.overWriteBtn.Location = new System.Drawing.Point(2, 2);
            this.overWriteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.overWriteBtn.Name = "overWriteBtn";
            this.overWriteBtn.Size = new System.Drawing.Size(81, 39);
            this.overWriteBtn.TabIndex = 0;
            this.overWriteBtn.Text = "Overwrite";
            this.overWriteBtn.UseVisualStyleBackColor = true;
            this.overWriteBtn.Click += new System.EventHandler(this.overWriteBtn_Click);
            // 
            // addDuplicateBtn
            // 
            this.addDuplicateBtn.Location = new System.Drawing.Point(87, 2);
            this.addDuplicateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addDuplicateBtn.Name = "addDuplicateBtn";
            this.addDuplicateBtn.Size = new System.Drawing.Size(81, 39);
            this.addDuplicateBtn.TabIndex = 1;
            this.addDuplicateBtn.Text = "Keep both";
            this.addDuplicateBtn.UseVisualStyleBackColor = true;
            this.addDuplicateBtn.Click += new System.EventHandler(this.addDuplicateBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(172, 2);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(81, 39);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // customDialogWarningLabel
            // 
            this.customDialogWarningLabel.AutoSize = true;
            this.customDialogWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.customDialogWarningLabel.Location = new System.Drawing.Point(26, 17);
            this.customDialogWarningLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customDialogWarningLabel.Name = "customDialogWarningLabel";
            this.customDialogWarningLabel.Size = new System.Drawing.Size(284, 20);
            this.customDialogWarningLabel.TabIndex = 1;
            this.customDialogWarningLabel.Text = "filename have existed, would you like to";
            // 
            // customDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 110);
            this.Controls.Add(this.customDialogWarningLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "customDialog";
            this.Text = "customDialog";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button overWriteBtn;
        private System.Windows.Forms.Button addDuplicateBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label customDialogWarningLabel;
    }
}
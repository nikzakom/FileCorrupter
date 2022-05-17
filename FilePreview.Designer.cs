
namespace FileCorrupter
{
    partial class FilePreview
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
            this.sourceFileTb = new System.Windows.Forms.TextBox();
            this.corruptedFileTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fakeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sourceFileTb
            // 
            this.sourceFileTb.Location = new System.Drawing.Point(12, 62);
            this.sourceFileTb.Multiline = true;
            this.sourceFileTb.Name = "sourceFileTb";
            this.sourceFileTb.ReadOnly = true;
            this.sourceFileTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sourceFileTb.Size = new System.Drawing.Size(375, 375);
            this.sourceFileTb.TabIndex = 0;
            // 
            // corruptedFileTb
            // 
            this.corruptedFileTb.Location = new System.Drawing.Point(413, 63);
            this.corruptedFileTb.Multiline = true;
            this.corruptedFileTb.Name = "corruptedFileTb";
            this.corruptedFileTb.ReadOnly = true;
            this.corruptedFileTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.corruptedFileTb.Size = new System.Drawing.Size(375, 375);
            this.corruptedFileTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Corrupted file";
            // 
            // fakeLabel
            // 
            this.fakeLabel.AutoSize = true;
            this.fakeLabel.Location = new System.Drawing.Point(391, 2);
            this.fakeLabel.Name = "fakeLabel";
            this.fakeLabel.Size = new System.Drawing.Size(0, 15);
            this.fakeLabel.TabIndex = 4;
            // 
            // FilePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fakeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.corruptedFileTb);
            this.Controls.Add(this.sourceFileTb);
            this.Name = "FilePreview";
            this.Text = "FilePreview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceFileTb;
        private System.Windows.Forms.TextBox corruptedFileTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fakeLabel;
    }
}
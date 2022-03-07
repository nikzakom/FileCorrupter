
namespace FileCorrupter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainActionBtn = new System.Windows.Forms.Button();
            this.debugTb = new System.Windows.Forms.TextBox();
            this.filePathTb = new System.Windows.Forms.TextBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // mainActionBtn
            // 
            this.mainActionBtn.Location = new System.Drawing.Point(251, 65);
            this.mainActionBtn.Name = "mainActionBtn";
            this.mainActionBtn.Size = new System.Drawing.Size(164, 57);
            this.mainActionBtn.TabIndex = 0;
            this.mainActionBtn.Text = "Corrupt file";
            this.mainActionBtn.UseVisualStyleBackColor = true;
            this.mainActionBtn.Click += new System.EventHandler(this.MainActionBtn_Click);
            // 
            // debugTb
            // 
            this.debugTb.Location = new System.Drawing.Point(12, 139);
            this.debugTb.Multiline = true;
            this.debugTb.Name = "debugTb";
            this.debugTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugTb.Size = new System.Drawing.Size(660, 272);
            this.debugTb.TabIndex = 1;
            // 
            // filePathTb
            // 
            this.filePathTb.Location = new System.Drawing.Point(12, 24);
            this.filePathTb.Name = "filePathTb";
            this.filePathTb.ReadOnly = true;
            this.filePathTb.Size = new System.Drawing.Size(568, 23);
            this.filePathTb.TabIndex = 2;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(597, 24);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFileBtn.TabIndex = 3;
            this.selectFileBtn.Text = "Select file";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 423);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.filePathTb);
            this.Controls.Add(this.debugTb);
            this.Controls.Add(this.mainActionBtn);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileCorrupter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainActionBtn;
        private System.Windows.Forms.TextBox debugTb;
        private System.Windows.Forms.TextBox filePathTb;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


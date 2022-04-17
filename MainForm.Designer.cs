
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainActionBtn = new System.Windows.Forms.Button();
            this.debugTb = new System.Windows.Forms.TextBox();
            this.filePathTb = new System.Windows.Forms.TextBox();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cleanLogBtn = new System.Windows.Forms.Button();
            this.openFolderBtn = new System.Windows.Forms.Button();
            this.showFilePreviewBtn = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainActionBtn
            // 
            this.mainActionBtn.Location = new System.Drawing.Point(23, 63);
            this.mainActionBtn.Name = "mainActionBtn";
            this.mainActionBtn.Size = new System.Drawing.Size(164, 57);
            this.mainActionBtn.TabIndex = 0;
            this.mainActionBtn.Text = "Corrupt and save file";
            this.mainActionBtn.UseVisualStyleBackColor = true;
            this.mainActionBtn.Click += new System.EventHandler(this.MainActionBtn_Click);
            // 
            // debugTb
            // 
            this.debugTb.Location = new System.Drawing.Point(23, 139);
            this.debugTb.Multiline = true;
            this.debugTb.Name = "debugTb";
            this.debugTb.ReadOnly = true;
            this.debugTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugTb.Size = new System.Drawing.Size(639, 271);
            this.debugTb.TabIndex = 1;
            // 
            // filePathTb
            // 
            this.filePathTb.Location = new System.Drawing.Point(23, 24);
            this.filePathTb.Name = "filePathTb";
            this.filePathTb.ReadOnly = true;
            this.filePathTb.Size = new System.Drawing.Size(549, 23);
            this.filePathTb.TabIndex = 2;
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(587, 24);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFileBtn.TabIndex = 3;
            this.selectFileBtn.Text = "Select file";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // cleanLogBtn
            // 
            this.cleanLogBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cleanLogBtn.BackgroundImage")));
            this.cleanLogBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cleanLogBtn.Location = new System.Drawing.Point(610, 377);
            this.cleanLogBtn.Name = "cleanLogBtn";
            this.cleanLogBtn.Size = new System.Drawing.Size(32, 32);
            this.cleanLogBtn.TabIndex = 4;
            this.cleanLogBtn.UseVisualStyleBackColor = true;
            this.cleanLogBtn.Click += new System.EventHandler(this.cleanLogBtn_Click);
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.Location = new System.Drawing.Point(417, 63);
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.Size = new System.Drawing.Size(155, 57);
            this.openFolderBtn.TabIndex = 5;
            this.openFolderBtn.Text = "Open folder";
            this.openFolderBtn.UseVisualStyleBackColor = true;
            this.openFolderBtn.Click += new System.EventHandler(this.openFolderBtn_Click);
            // 
            // showFilePreviewBtn
            // 
            this.showFilePreviewBtn.Location = new System.Drawing.Point(222, 63);
            this.showFilePreviewBtn.Name = "showFilePreviewBtn";
            this.showFilePreviewBtn.Size = new System.Drawing.Size(164, 57);
            this.showFilePreviewBtn.TabIndex = 6;
            this.showFilePreviewBtn.Text = "Show HEX file preview";
            this.showFilePreviewBtn.UseVisualStyleBackColor = true;
            this.showFilePreviewBtn.Click += new System.EventHandler(this.showFilePreviewBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(587, 63);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(75, 57);
            this.infoBtn.TabIndex = 7;
            this.infoBtn.Text = "info";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 423);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.showFilePreviewBtn);
            this.Controls.Add(this.openFolderBtn);
            this.Controls.Add(this.cleanLogBtn);
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
        private System.Windows.Forms.Button cleanLogBtn;
        private System.Windows.Forms.Button openFolderBtn;
        private System.Windows.Forms.Button showFilePreviewBtn;
        private System.Windows.Forms.Button infoBtn;
    }
}


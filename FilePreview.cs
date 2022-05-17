using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileCorrupter
{
    public partial class FilePreview : Form
    {
        public FilePreview(byte[] sourceFile, byte[] corruptedFile)
        {
            InitializeComponent();
            // hide focus
            this.ActiveControl = fakeLabel;
            Print(this.sourceFileTb, sourceFile);
            Print(this.corruptedFileTb, corruptedFile);
        }

        private void Print(TextBox tb, byte[]file)
        {
            var bytes = BitConverter.ToString(file);

            int i = 0;
            int limit = 1024;

            tb.Text += $"Shown first {limit.ToString()} bytes:";
            tb.Text += Environment.NewLine;
            tb.Text += Environment.NewLine;

            while (i < limit && i < file.Length)
            {
                tb.Text += bytes[i];
                i++;
            }
        }
    }
}

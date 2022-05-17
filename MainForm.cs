using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCorrupter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // hide focus
            this.ActiveControl = fakeLabel;
        }

        private string sourceFileName;
        private string corruptedFileName;

        private byte[] sourceFile;
        private byte[] corruptedFile;

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();         
      
            if (openFileDialog.CheckFileExists == false)
            {
                ShowErrorMessage("File doesn't exist!");
                return;
            }

            sourceFileName = openFileDialog.FileName;

            filePathTb.Text = sourceFileName;

            Print("Selected file: " + sourceFileName);
        }

        private void MainActionBtn_Click(object sender, EventArgs e)
        {
            if (sourceFileName == string.Empty || sourceFileName == null)
            {
                ShowErrorMessage("File was not selected!");
                return;
            }

            try
            {      
                sourceFile = ReadSourceFile(sourceFileName);

                if (sourceFile.Length < 1)
                {
                    ShowErrorMessage("File is empty!");
                    return;
                }

                Print("File readed successfully!");
                Print("Processing...");
                //Print(BitConverter.ToString(sourceFile));

                corruptedFile = CorruptFile(sourceFile);

                if (corruptedFile == null)
                {
                    MessageBox.Show("Something went wrong, please, try again!", "Error");
                    return;
                }

                string dirPath = Path.GetDirectoryName(sourceFileName);
                string name = Path.GetFileNameWithoutExtension(sourceFileName);
                string extension = Path.GetExtension(sourceFileName);

                corruptedFileName = @$"{dirPath}\{name}_corrupted{extension}";

                SaveCorruptedFile(corruptedFile, corruptedFileName);

                Print("Corrupted file was saved successfully!");
                Print(@$"Path : {corruptedFileName}");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.ToString());
            }
                
        }

        private byte[] ReadSourceFile(string filePath)
        {
            var file = File.ReadAllBytes(filePath);
            return file;
        }

        private byte[] CorruptFile(byte[] file)
        {
            try
            {
                byte[] f = new byte[file.Length]; 
                Array.Copy(file, f, file.Length);

                byte replacementByte = 255;

                int offset = 16;

                if (f.Length <= offset)
                {
                    offset = f.Length / 4;
                }

                for (int i = 0; i < offset; i++)
                {
                    f[i] = replacementByte;
                }

                return f;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.ToString());
                return null;
            }
        }

        private void SaveCorruptedFile(byte[] file, string path)
        {
            if (file == null)
            {
                ShowErrorMessage("Something went wrong...");
                return;
            }

            try
            {
                File.WriteAllBytesAsync(path, file);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.ToString());
            }
        }

        private void Print (string text)
        {
            debugTb.Text += text;
            debugTb.Text += Environment.NewLine;
        }

        /// <summary>
        /// Shows a message box with title "Error" and custom error text
        /// </summary>
        private void ShowErrorMessage(string errorText)
        {
            MessageBox.Show(errorText, "Error");
        }

        private void cleanLogBtn_Click(object sender, EventArgs e)
        {
            debugTb.Text = "";
        }

        private void showFilePreviewBtn_Click(object sender, EventArgs e)
        {
            if (sourceFileName == string.Empty || sourceFileName == null)
            {
                ShowErrorMessage("File was not selected!");
                return;
            }

            try
            {
                sourceFile = ReadSourceFile(sourceFileName);

                if (sourceFile.Length < 1)
                {
                    ShowErrorMessage("File is empty!");
                    return;
                }

                corruptedFile = CorruptFile(sourceFile);

                if (corruptedFile == null)
                {
                    ShowErrorMessage("Something went wrong, please, try again!");
                    return;
                }

                Form filePreview = new FilePreview(sourceFile, corruptedFile);
                filePreview.Show();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.ToString());
            }        
        }

        private void openFolderBtn_Click(object sender, EventArgs e)
        {
            if (sourceFileName == string.Empty || sourceFileName == null)
            {
                ShowErrorMessage("File was not selected!");
                return;
            }

            string dirPath = Path.GetDirectoryName(sourceFileName);

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = dirPath,
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            ShowErrorMessage("Not implemented yet");
        }
    }
}

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

            Log("Selected file: " + sourceFileName);
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
                sourceFile = ReadSourceFile();

                if (sourceFile.Length <= 1)
                {
                    ShowErrorMessage("File is empty!");
                    return;
                }

                Log("File readed successfully!");
                Log(BitConverter.ToString(sourceFile));

                corruptedFile = CorruptFile(sourceFile);

                string dirPath = Path.GetDirectoryName(sourceFileName);
                string name = Path.GetFileNameWithoutExtension(sourceFileName);
                string extension = Path.GetExtension(sourceFileName);

                Log(dirPath);
                Log(name);
                Log(extension);

                corruptedFileName = @$"{dirPath}\{name}_corrupted{extension}";

                Log(corruptedFileName);

                SaveCorruptedFile(corruptedFile, corruptedFileName);

                Log("Corrupted file was saved");

                Log(BitConverter.ToString(corruptedFile));
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.ToString());
            }
                
        }

        private byte[] ReadSourceFile()
        {
            var file = File.ReadAllBytes(sourceFileName);
            return file;
        }

        private byte[] CorruptFile(byte[] file)
        {
            try
            {
                var f = file;

                byte replacementByte = 255;

                // TODO move to consts/config class
                int offset = 8;

                if (f.Length <= offset)
                {
                    offset = f.Length;
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

        private void Log (string text)
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

    }
}

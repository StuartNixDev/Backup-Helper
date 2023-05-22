using Microsoft.VisualBasic.Logging;
using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Serilog;

namespace Backup_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitiateLog();
            folderName.Text = "\\" + "AutoBackup " + DateTime.Today.ToString("dd-MM-yyyy");
            path.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileCount.Text = "0";
            TargetDirectories.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            TargetDirectories.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            TargetDirectories.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            TargetDirectories.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

        }


        private void SelectDirectories_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog result = new FolderBrowserDialog();
            if (result.ShowDialog() == DialogResult.OK)
            {
                string folderName = result.SelectedPath;
                TargetDirectories.Items.Add(folderName);

            }

        }

        private void ScanDirectories_Click(object sender, EventArgs e)
        {
            Counter.FileCount = 0;
            Results.Items.Clear();
            try
            {

                foreach (string dirs in TargetDirectories.Items)
                {
                    string[] getFiles = Directory.GetFiles(dirs, "*", System.IO.SearchOption.AllDirectories);

                    foreach (string file in getFiles)
                    {
                        if (Results.Items.Contains(file))
                        {
                            continue;
                        }
                        else
                        {
                            Results.Items.Add(file);
                            Counter.FileCount++;
                        }
                    }

                }
                RunBackup.Enabled = true;
                FileCount.Text = Counter.FileCount.ToString();
            }
            catch
            {
                MessageBox.Show("Error! Could not access Directory");
            }
        }


        private void TargetDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog target = new FolderBrowserDialog();
            if (target.ShowDialog() == DialogResult.OK)
            {
                string folderName = target.SelectedPath;
                path.Text = folderName;

            }
        }


        private void RunBackup_Click(object sender, EventArgs e)
        {
            Counter.count = 0;
            try
            {
                foreach (string file in Results.Items)
                {
                    string fileName = Path.GetFileName(file);
                    string fullpath = Path.Combine(path.Text.ToString() + folderName.Text.ToString());
                    string target = Path.Combine(fullpath, fileName);

                    if (!Directory.Exists(fullpath))
                    {
                        Directory.CreateDirectory(fullpath);
                        File.Copy(file, target, true);
                        Counter.count++;

                    }

                    if (File.Exists(target))
                    {
                        FileInfo fileInfoSource = new FileInfo(file);
                        FileInfo fileInfoTarget = new FileInfo(target);


                        if (fileInfoSource.LastWriteTime > fileInfoTarget.LastWriteTime)
                        {
                            File.Copy(file, target, true);
                            Counter.count++;

                        }
                        else
                        {
                            continue;
                        }

                    }
                    else
                    {
                        File.Copy(file, target, true);
                        Counter.count++;

                    }

                }
                MessageBox.Show($"Total number of files saved is: {Counter.count}");
                Serilog.Log.Information($"Total number of files backed up is: {Counter.count}");
                Results.Items.Clear();
                FileCount.Text = "0";
            }
            catch (IOException)
            {

                MessageBox.Show("An Error occured when running backup");

            }

        }

        private void Removed_Click(object sender, EventArgs e)

        {

            if (this.TargetDirectories.SelectedIndex >= 0)
            {
                this.TargetDirectories.Items.RemoveAt(this.TargetDirectories.SelectedIndex);
                Counter.count--;
            }

        }

        private void RemoveFromResults_Click(object sender, EventArgs e)
        {
            if (this.Results.SelectedIndex >= 0)
            {
                this.Results.Items.RemoveAt(this.Results.SelectedIndex);
                Counter.FileCount--;
                FileCount.Text = Counter.FileCount.ToString();
            }
        }

        private void InitiateLog()
        {
            Serilog.Log.Logger = new LoggerConfiguration()
                    .WriteTo.File("C:\\Users\\stuar\\OneDrive\\Desktop\\Projects\\Backup Helper\\Log.txt")
                    .CreateLogger();
        }
    }

}



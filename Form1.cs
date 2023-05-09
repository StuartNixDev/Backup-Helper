using Microsoft.VisualBasic.Logging;
using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Backup_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            folderName.Text = "\\" + "AutoBackup " + DateTime.Today.ToString("dd-MM-yyyy");
            path.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //TargetDirectories.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            //TargetDirectories.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            //TargetDirectories.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            //TargetDirectories.Items.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

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
                        }
                    }

                }
                RunBackup.Enabled = true;

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
                Results.Items.Clear();
            }
            catch (IOException)
            {

                MessageBox.Show("An Error occured when running backup");

            }

        }


    }

}



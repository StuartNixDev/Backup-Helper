namespace Backup_Helper
{
    partial class Form1
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
            Results = new ListBox();
            ScanDirectories = new Button();
            RunBackup = new Button();
            SelectDirectories = new Button();
            openFileDialog1 = new OpenFileDialog();
            TargetDirectories = new ListBox();
            TargetDirectory = new Button();
            path = new TextBox();
            folderName = new TextBox();
            label1 = new Label();
            Removed = new Button();
            RemoveFromResults = new Button();
            FilesSelected = new Label();
            FileCount = new Label();
            SuspendLayout();
            // 
            // Results
            // 
            Results.FormattingEnabled = true;
            Results.ItemHeight = 20;
            Results.Location = new Point(21, 415);
            Results.Name = "Results";
            Results.SelectionMode = SelectionMode.MultiExtended;
            Results.Size = new Size(754, 304);
            Results.Sorted = true;
            Results.TabIndex = 0;
            // 
            // ScanDirectories
            // 
            ScanDirectories.Location = new Point(22, 168);
            ScanDirectories.Name = "ScanDirectories";
            ScanDirectories.Size = new Size(202, 31);
            ScanDirectories.TabIndex = 1;
            ScanDirectories.Text = "Scan Directories";
            ScanDirectories.UseVisualStyleBackColor = true;
            ScanDirectories.Click += ScanDirectories_Click;
            // 
            // RunBackup
            // 
            RunBackup.Enabled = false;
            RunBackup.Location = new Point(22, 320);
            RunBackup.Name = "RunBackup";
            RunBackup.Size = new Size(168, 45);
            RunBackup.TabIndex = 2;
            RunBackup.Text = "Run Backup";
            RunBackup.UseVisualStyleBackColor = true;
            RunBackup.Click += RunBackup_Click;
            // 
            // SelectDirectories
            // 
            SelectDirectories.Location = new Point(22, 121);
            SelectDirectories.Margin = new Padding(3, 4, 3, 4);
            SelectDirectories.Name = "SelectDirectories";
            SelectDirectories.Size = new Size(202, 31);
            SelectDirectories.TabIndex = 3;
            SelectDirectories.Text = "Select Directories";
            SelectDirectories.UseVisualStyleBackColor = true;
            SelectDirectories.Click += SelectDirectories_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // TargetDirectories
            // 
            TargetDirectories.FormattingEnabled = true;
            TargetDirectories.ItemHeight = 20;
            TargetDirectories.Location = new Point(285, 121);
            TargetDirectories.Margin = new Padding(3, 4, 3, 4);
            TargetDirectories.Name = "TargetDirectories";
            TargetDirectories.Size = new Size(490, 104);
            TargetDirectories.TabIndex = 4;
            // 
            // TargetDirectory
            // 
            TargetDirectory.Location = new Point(22, 35);
            TargetDirectory.Margin = new Padding(3, 4, 3, 4);
            TargetDirectory.Name = "TargetDirectory";
            TargetDirectory.Size = new Size(202, 31);
            TargetDirectory.TabIndex = 5;
            TargetDirectory.Text = "Target Directory";
            TargetDirectory.UseVisualStyleBackColor = true;
            TargetDirectory.Click += TargetDirectory_Click;
            // 
            // path
            // 
            path.Location = new Point(285, 39);
            path.Margin = new Padding(3, 4, 3, 4);
            path.Name = "path";
            path.Size = new Size(491, 27);
            path.TabIndex = 6;
            // 
            // folderName
            // 
            folderName.Location = new Point(285, 78);
            folderName.Name = "folderName";
            folderName.Size = new Size(491, 27);
            folderName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(101, 80);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 8;
            label1.Text = "Folder Name:";
            // 
            // Removed
            // 
            Removed.Location = new Point(285, 238);
            Removed.Name = "Removed";
            Removed.Size = new Size(163, 29);
            Removed.TabIndex = 9;
            Removed.Text = "Remove";
            Removed.UseVisualStyleBackColor = true;
            Removed.Click += Removed_Click;
            // 
            // RemoveFromResults
            // 
            RemoveFromResults.Location = new Point(21, 732);
            RemoveFromResults.Name = "RemoveFromResults";
            RemoveFromResults.Size = new Size(173, 29);
            RemoveFromResults.TabIndex = 10;
            RemoveFromResults.Text = "Remove";
            RemoveFromResults.UseVisualStyleBackColor = true;
            RemoveFromResults.Click += RemoveFromResults_Click;
            // 
            // FilesSelected
            // 
            FilesSelected.AutoSize = true;
            FilesSelected.Location = new Point(22, 380);
            FilesSelected.Name = "FilesSelected";
            FilesSelected.Size = new Size(102, 20);
            FilesSelected.TabIndex = 11;
            FilesSelected.Text = "Files Selected:";
            // 
            // FileCount
            // 
            FileCount.AutoSize = true;
            FileCount.Location = new Point(135, 381);
            FileCount.Name = "FileCount";
            FileCount.Size = new Size(0, 20);
            FileCount.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 783);
            Controls.Add(FileCount);
            Controls.Add(FilesSelected);
            Controls.Add(RemoveFromResults);
            Controls.Add(Removed);
            Controls.Add(label1);
            Controls.Add(folderName);
            Controls.Add(path);
            Controls.Add(TargetDirectory);
            Controls.Add(TargetDirectories);
            Controls.Add(SelectDirectories);
            Controls.Add(RunBackup);
            Controls.Add(ScanDirectories);
            Controls.Add(Results);
            Name = "Form1";
            Text = "Backup Helper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Results;
        private Button ScanDirectories;
        private Button RunBackup;
        private Button SelectDirectories;
        private OpenFileDialog openFileDialog1;
        private ListBox TargetDirectories;
        private Button TargetDirectory;
        private TextBox path;
        private TextBox folderName;
        private Label label1;
        private Button Removed;
        private Button RemoveFromResults;
        private Label FilesSelected;
        private Label FileCount;
    }
}
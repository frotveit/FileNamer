using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FileNamer
{
    public partial class FileNamerForm : Form, IFileNamerUi
    {
        public const string SortDateTypeCreate = "Creation Date";
        public const string SortDateTypeLastUpdate = "Last Update Date";

        private readonly FileNamer _fileNamer;


        public FileNamerForm()
        {
            InitializeComponent();
            _fileNamer = new FileNamer(this);
        }

        private SortDateType GetSortDateType()
        {
            switch (dateTypeUpDown.Text)
            {
                case SortDateTypeCreate:
                    return SortDateType.Created;
                case SortDateTypeLastUpdate:
                    return SortDateType.LastChanged;
            }
            return SortDateType.Created;
        }

        private void DoRenumberFolder(object sender, EventArgs e)
        {
            _fileNamer.RenumberFolder(folderTextBox.Text, useDatePrefixCheckBox.Checked, fileNameTextBox.Text, 
                useExistingFileNameCheckBox.Checked, (int)numberToRemoveNumericUpDown.Value, GetSortDateType());
        }

        private void DoRename(object sender, EventArgs e)
        {
            _fileNamer.Rename(folderTextBox.Text, oldFilePrefixTextBox.Text, newFilePrefixTextBox.Text);
        }

        private void DoRenameSelected(object sender, EventArgs e)
        {
            var fileList = GetSelectedFiles();
            _fileNamer.RenameSelected(folderTextBox.Text, oldFilePrefixTextBox.Text, newFilePrefixTextBox.Text, fileList);
        }

        private List<string> GetSelectedFiles()
        {
            List<string> fileList = new List<string>();
            foreach (string fileName in fileListBox.SelectedItems)
                fileList.Add(fileName);
            return fileList;
        }


        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void DoChooseFolder(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderTextBox.Text = folderBrowserDialog.SelectedPath;

                _fileNamer.UpdateFileList(folderTextBox.Text);
            }
        }

        public void UpdateFileList(List<string> fileList)
        {
            fileListBox.Items.Clear();
            foreach (string fileName in fileList)
                fileListBox.Items.Add(fileName);
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void renumberGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}

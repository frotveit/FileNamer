using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FileNamer
{
    public partial class FileNamerForm : Form
    {
        public const string SortDateTypeCreate = "Creation Date";
        public const string SortDateTypeLastUpdate = "Last Update Date";

        private readonly IFileWrapper _fileWrapper;
        private readonly FileRenamer _fileRenamer;
        private readonly FileRenumbering _fileRenumbering;

        public FileNamerForm()
        {
            InitializeComponent();
            _fileWrapper = new FileWrapper();
            _fileRenamer = new FileRenamer(new FileWrapper());
            _fileRenumbering = new FileRenumbering(new FileWrapper());
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
            _fileRenumbering.RenumberFolder(folderTextBox.Text, useDatePrefixCheckBox.Checked, fileNameTextBox.Text, 
                useExistingFileNameCheckBox.Checked, (int)numberToRemoveNumericUpDown.Value, GetSortDateType());

            UpdateFileListBox();
        }

        private void DoRename(object sender, EventArgs e)
        {
            _fileRenamer.RenameFilesInFolder(folderTextBox.Text, oldFilePrefixTextBox.Text, newFilePrefixTextBox.Text);

            UpdateFileListBox();
        }

        private void DoRenameSelected(object sender, EventArgs e)
        {
            List<string> fileList = new List<string>();
            foreach (string fileName in fileListBox.SelectedItems)
                fileList.Add(fileName);

            _fileRenamer.RenameSelectedFilesInFolder(folderTextBox.Text, oldFilePrefixTextBox.Text, newFilePrefixTextBox.Text, fileList);

            UpdateFileListBox();
        }


        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void DoChooseFolder(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderTextBox.Text = folderBrowserDialog.SelectedPath;

                UpdateFileListBox();
            }
        }

        private void UpdateFileListBox()
        {
            List<string> fileList = _fileWrapper.GetFileList(folderTextBox.Text);
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

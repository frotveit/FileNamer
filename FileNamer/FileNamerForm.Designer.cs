namespace FileNamer
{
    partial class FileNamerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RenameButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.oldFilePrefixTextBox = new System.Windows.Forms.TextBox();
            this.oldFilePrefixLabel = new System.Windows.Forms.Label();
            this.newFilePrefixLabel = new System.Windows.Forms.Label();
            this.newFilePrefixTextBox = new System.Windows.Forms.TextBox();
            this.ChooseFolferButton = new System.Windows.Forms.Button();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.renameSelectedButton = new System.Windows.Forms.Button();
            this.prefixRenamingGroupBox = new System.Windows.Forms.GroupBox();
            this.renumberGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTypeUpDown = new System.Windows.Forms.DomainUpDown();
            this.numberToRemoveLabel = new System.Windows.Forms.Label();
            this.numberToRemoveNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.useExistingFileNameCheckBox = new System.Windows.Forms.CheckBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.useDatePrefixCheckBox = new System.Windows.Forms.CheckBox();
            this.renumberButton = new System.Windows.Forms.Button();
            this.fileGridView = new System.Windows.Forms.DataGridView();
            this.FileNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileCreatedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileChangedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateToUseLabel = new System.Windows.Forms.Label();
            this.prefixRenamingGroupBox.SuspendLayout();
            this.renumberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberToRemoveNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RenameButton
            // 
            this.RenameButton.Location = new System.Drawing.Point(27, 129);
            this.RenameButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(192, 35);
            this.RenameButton.TabIndex = 0;
            this.RenameButton.Text = "Rename all";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.DoRename);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // oldFilePrefixTextBox
            // 
            this.oldFilePrefixTextBox.Location = new System.Drawing.Point(243, 29);
            this.oldFilePrefixTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oldFilePrefixTextBox.Name = "oldFilePrefixTextBox";
            this.oldFilePrefixTextBox.Size = new System.Drawing.Size(148, 26);
            this.oldFilePrefixTextBox.TabIndex = 1;
            // 
            // oldFilePrefixLabel
            // 
            this.oldFilePrefixLabel.AutoSize = true;
            this.oldFilePrefixLabel.Location = new System.Drawing.Point(22, 40);
            this.oldFilePrefixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oldFilePrefixLabel.Name = "oldFilePrefixLabel";
            this.oldFilePrefixLabel.Size = new System.Drawing.Size(99, 20);
            this.oldFilePrefixLabel.TabIndex = 2;
            this.oldFilePrefixLabel.Text = "Old file prefix";
            // 
            // newFilePrefixLabel
            // 
            this.newFilePrefixLabel.AutoSize = true;
            this.newFilePrefixLabel.Location = new System.Drawing.Point(22, 83);
            this.newFilePrefixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newFilePrefixLabel.Name = "newFilePrefixLabel";
            this.newFilePrefixLabel.Size = new System.Drawing.Size(106, 20);
            this.newFilePrefixLabel.TabIndex = 3;
            this.newFilePrefixLabel.Text = "New file prefix";
            // 
            // newFilePrefixTextBox
            // 
            this.newFilePrefixTextBox.Location = new System.Drawing.Point(243, 83);
            this.newFilePrefixTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newFilePrefixTextBox.Name = "newFilePrefixTextBox";
            this.newFilePrefixTextBox.Size = new System.Drawing.Size(148, 26);
            this.newFilePrefixTextBox.TabIndex = 4;
            // 
            // ChooseFolferButton
            // 
            this.ChooseFolferButton.Location = new System.Drawing.Point(18, 117);
            this.ChooseFolferButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChooseFolferButton.Name = "ChooseFolferButton";
            this.ChooseFolferButton.Size = new System.Drawing.Size(192, 35);
            this.ChooseFolferButton.TabIndex = 5;
            this.ChooseFolferButton.Text = "Choose folder";
            this.ChooseFolferButton.UseVisualStyleBackColor = true;
            this.ChooseFolferButton.Click += new System.EventHandler(this.DoChooseFolder);
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(236, 121);
            this.folderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.ReadOnly = true;
            this.folderTextBox.Size = new System.Drawing.Size(640, 26);
            this.folderTextBox.TabIndex = 6;
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.instructionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionLabel.Location = new System.Drawing.Point(18, 24);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(858, 68);
            this.instructionLabel.TabIndex = 7;
            this.instructionLabel.Text = "This application rename and renumber the files in a folder. First choose a folder" +
    ", then enter a common name for the files, and press rename button.";
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.HorizontalScrollbar = true;
            this.fileListBox.ItemHeight = 20;
            this.fileListBox.Location = new System.Drawing.Point(533, 192);
            this.fileListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.fileListBox.Size = new System.Drawing.Size(343, 664);
            this.fileListBox.TabIndex = 8;
            // 
            // renameSelectedButton
            // 
            this.renameSelectedButton.Location = new System.Drawing.Point(27, 189);
            this.renameSelectedButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.renameSelectedButton.Name = "renameSelectedButton";
            this.renameSelectedButton.Size = new System.Drawing.Size(192, 35);
            this.renameSelectedButton.TabIndex = 9;
            this.renameSelectedButton.Text = "Rename selected";
            this.renameSelectedButton.UseVisualStyleBackColor = true;
            this.renameSelectedButton.Click += new System.EventHandler(this.DoRenameSelected);
            // 
            // prefixRenamingGroupBox
            // 
            this.prefixRenamingGroupBox.Controls.Add(this.oldFilePrefixLabel);
            this.prefixRenamingGroupBox.Controls.Add(this.renameSelectedButton);
            this.prefixRenamingGroupBox.Controls.Add(this.oldFilePrefixTextBox);
            this.prefixRenamingGroupBox.Controls.Add(this.newFilePrefixLabel);
            this.prefixRenamingGroupBox.Controls.Add(this.newFilePrefixTextBox);
            this.prefixRenamingGroupBox.Controls.Add(this.RenameButton);
            this.prefixRenamingGroupBox.Location = new System.Drawing.Point(18, 584);
            this.prefixRenamingGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prefixRenamingGroupBox.Name = "prefixRenamingGroupBox";
            this.prefixRenamingGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prefixRenamingGroupBox.Size = new System.Drawing.Size(470, 272);
            this.prefixRenamingGroupBox.TabIndex = 10;
            this.prefixRenamingGroupBox.TabStop = false;
            this.prefixRenamingGroupBox.Text = "Prefix renaming";
            // 
            // renumberGroupBox
            // 
            this.renumberGroupBox.Controls.Add(this.dateToUseLabel);
            this.renumberGroupBox.Controls.Add(this.dateTypeUpDown);
            this.renumberGroupBox.Controls.Add(this.numberToRemoveLabel);
            this.renumberGroupBox.Controls.Add(this.numberToRemoveNumericUpDown);
            this.renumberGroupBox.Controls.Add(this.useExistingFileNameCheckBox);
            this.renumberGroupBox.Controls.Add(this.fileNameLabel);
            this.renumberGroupBox.Controls.Add(this.fileNameTextBox);
            this.renumberGroupBox.Controls.Add(this.useDatePrefixCheckBox);
            this.renumberGroupBox.Controls.Add(this.renumberButton);
            this.renumberGroupBox.Location = new System.Drawing.Point(18, 192);
            this.renumberGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.renumberGroupBox.Name = "renumberGroupBox";
            this.renumberGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.renumberGroupBox.Size = new System.Drawing.Size(470, 358);
            this.renumberGroupBox.TabIndex = 11;
            this.renumberGroupBox.TabStop = false;
            this.renumberGroupBox.Text = "Rename and Renumber files in folder";
            this.renumberGroupBox.Enter += new System.EventHandler(this.renumberGroupBox_Enter);
            // 
            // dateTypeUpDown
            // 
            this.dateTypeUpDown.Location = new System.Drawing.Point(243, 221);
            this.dateTypeUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTypeUpDown.Name = "dateTypeUpDown";
            this.dateTypeUpDown.Size = new System.Drawing.Size(204, 26);
            this.dateTypeUpDown.TabIndex = 7;
            this.dateTypeUpDown.Items.Add(SortDateTypeCreate);
            this.dateTypeUpDown.Items.Add(SortDateTypeLastUpdate);
            this.dateTypeUpDown.Text = DefaultSortDateType;
            // 
            // numberToRemoveLabel
            // 
            this.numberToRemoveLabel.AutoSize = true;
            this.numberToRemoveLabel.Location = new System.Drawing.Point(22, 172);
            this.numberToRemoveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberToRemoveLabel.Name = "numberToRemoveLabel";
            this.numberToRemoveLabel.Size = new System.Drawing.Size(313, 20);
            this.numberToRemoveLabel.TabIndex = 6;
            this.numberToRemoveLabel.Text = "Remove x first chars from existing file name";
            // 
            // numberToRemoveNumericUpDown
            // 
            this.numberToRemoveNumericUpDown.Location = new System.Drawing.Point(376, 162);
            this.numberToRemoveNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberToRemoveNumericUpDown.Name = "numberToRemoveNumericUpDown";
            this.numberToRemoveNumericUpDown.Size = new System.Drawing.Size(70, 26);
            this.numberToRemoveNumericUpDown.TabIndex = 5;
            // 
            // useExistingFileNameCheckBox
            // 
            this.useExistingFileNameCheckBox.AutoSize = true;
            this.useExistingFileNameCheckBox.Location = new System.Drawing.Point(27, 126);
            this.useExistingFileNameCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.useExistingFileNameCheckBox.Name = "useExistingFileNameCheckBox";
            this.useExistingFileNameCheckBox.Size = new System.Drawing.Size(369, 24);
            this.useExistingFileNameCheckBox.TabIndex = 4;
            this.useExistingFileNameCheckBox.Text = "Keep existing file name as part of new file name";
            this.useExistingFileNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fileNameLabel.Location = new System.Drawing.Point(27, 68);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(205, 20);
            this.fileNameLabel.TabIndex = 3;
            this.fileNameLabel.Text = "New file name common part";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(243, 68);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(202, 26);
            this.fileNameTextBox.TabIndex = 2;
            // 
            // useDatePrefixCheckBox
            // 
            this.useDatePrefixCheckBox.AutoSize = true;
            this.useDatePrefixCheckBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.useDatePrefixCheckBox.Checked = true;
            this.useDatePrefixCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useDatePrefixCheckBox.Location = new System.Drawing.Point(27, 31);
            this.useDatePrefixCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.useDatePrefixCheckBox.Name = "useDatePrefixCheckBox";
            this.useDatePrefixCheckBox.Size = new System.Drawing.Size(142, 24);
            this.useDatePrefixCheckBox.TabIndex = 1;
            this.useDatePrefixCheckBox.Text = "Prefix with date";
            this.useDatePrefixCheckBox.UseVisualStyleBackColor = false;
            // 
            // renumberButton
            // 
            this.renumberButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.renumberButton.Location = new System.Drawing.Point(25, 292);
            this.renumberButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.renumberButton.Name = "renumberButton";
            this.renumberButton.Size = new System.Drawing.Size(420, 35);
            this.renumberButton.TabIndex = 0;
            this.renumberButton.Text = "Rename and Renumber folder";
            this.renumberButton.UseVisualStyleBackColor = false;
            this.renumberButton.Click += new System.EventHandler(this.DoRenumberFolder);
            // 
            // fileGridView
            // 
            this.fileGridView.AllowUserToAddRows = false;
            this.fileGridView.AllowUserToDeleteRows = false;
            this.fileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileNameCol,
            this.FileCreatedCol,
            this.FileChangedCol});
            this.fileGridView.Location = new System.Drawing.Point(896, 192);
            this.fileGridView.Name = "fileGridView";
            this.fileGridView.ReadOnly = true;
            this.fileGridView.RowTemplate.Height = 28;
            this.fileGridView.Size = new System.Drawing.Size(674, 664);
            this.fileGridView.TabIndex = 12;
            // 
            // FileNameCol
            // 
            this.FileNameCol.DataPropertyName = "Name";
            this.FileNameCol.HeaderText = "Name";
            this.FileNameCol.Name = "FileNameCol";
            this.FileNameCol.ReadOnly = true;
            this.FileNameCol.Width = 150;
            // 
            // FileCreatedCol
            // 
            this.FileCreatedCol.DataPropertyName = "Created";
            this.FileCreatedCol.HeaderText = "Created";
            this.FileCreatedCol.Name = "FileCreatedCol";
            this.FileCreatedCol.ReadOnly = true;
            this.FileCreatedCol.Width = 120;
            // 
            // FileChangedCol
            // 
            this.FileChangedCol.HeaderText = "Changed";
            this.FileChangedCol.Name = "FileChangedCol";
            this.FileChangedCol.ReadOnly = true;
            this.FileChangedCol.Width = 120;
            // 
            // dateToUseLabel
            // 
            this.dateToUseLabel.AutoSize = true;
            this.dateToUseLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateToUseLabel.Location = new System.Drawing.Point(27, 223);
            this.dateToUseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateToUseLabel.Name = "dateToUseLabel";
            this.dateToUseLabel.Size = new System.Drawing.Size(92, 20);
            this.dateToUseLabel.TabIndex = 8;
            this.dateToUseLabel.Text = "Date to use";
            // 
            // FileNamerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 890);
            this.Controls.Add(this.fileGridView);
            this.Controls.Add(this.renumberGroupBox);
            this.Controls.Add(this.prefixRenamingGroupBox);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.ChooseFolferButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FileNamerForm";
            this.Text = "File Prefix Renamer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.prefixRenamingGroupBox.ResumeLayout(false);
            this.prefixRenamingGroupBox.PerformLayout();
            this.renumberGroupBox.ResumeLayout(false);
            this.renumberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberToRemoveNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox oldFilePrefixTextBox;
        private System.Windows.Forms.Label oldFilePrefixLabel;
        private System.Windows.Forms.Label newFilePrefixLabel;
        private System.Windows.Forms.TextBox newFilePrefixTextBox;
        private System.Windows.Forms.Button ChooseFolferButton;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Button renameSelectedButton;
        private System.Windows.Forms.GroupBox prefixRenamingGroupBox;
        private System.Windows.Forms.GroupBox renumberGroupBox;
        private System.Windows.Forms.Button renumberButton;
        private System.Windows.Forms.CheckBox useDatePrefixCheckBox;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.NumericUpDown numberToRemoveNumericUpDown;
        private System.Windows.Forms.CheckBox useExistingFileNameCheckBox;
        private System.Windows.Forms.Label numberToRemoveLabel;
        private System.Windows.Forms.DomainUpDown dateTypeUpDown;
        private System.Windows.Forms.DataGridView fileGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileCreatedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileChangedCol;
        private System.Windows.Forms.Label dateToUseLabel;
    }
}


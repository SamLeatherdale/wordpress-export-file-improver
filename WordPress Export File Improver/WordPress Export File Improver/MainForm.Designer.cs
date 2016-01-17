namespace WordPress_Duplicate_Resolver
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.openFileDialogXML = new System.Windows.Forms.OpenFileDialog();
			this.buttonSelectFiles = new System.Windows.Forms.Button();
			this.checkBoxLog = new System.Windows.Forms.CheckBox();
			this.groupBoxLogging = new System.Windows.Forms.GroupBox();
			this.comboBoxVerbosity = new System.Windows.Forms.ComboBox();
			this.labelVerbosity = new System.Windows.Forms.Label();
			this.folderBrowserDialogDestination = new System.Windows.Forms.FolderBrowserDialog();
			this.listBoxFileNames = new System.Windows.Forms.ListBox();
			this.buttonSelectDestination = new System.Windows.Forms.Button();
			this.textBoxDestination = new System.Windows.Forms.TextBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.groupBoxDestination = new System.Windows.Forms.GroupBox();
			this.labelDestination = new System.Windows.Forms.Label();
			this.radioButtonDestinationCustom = new System.Windows.Forms.RadioButton();
			this.radioButtonDestinationSource = new System.Windows.Forms.RadioButton();
			this.groupBoxMedia = new System.Windows.Forms.GroupBox();
			this.checkBoxRenameMedia = new System.Windows.Forms.CheckBox();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBoxDuplicates = new System.Windows.Forms.GroupBox();
			this.checkBoxRenameDuplicates = new System.Windows.Forms.CheckBox();
			this.labelSeparationCharacterDesc = new System.Windows.Forms.Label();
			this.labelOriginalName = new System.Windows.Forms.Label();
			this.textBoxSeparationCharacter = new System.Windows.Forms.TextBox();
			this.labelOrdinal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDownStartCounter = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownPadLength = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.labelPreview = new System.Windows.Forms.Label();
			this.groupBoxLogging.SuspendLayout();
			this.groupBoxDestination.SuspendLayout();
			this.groupBoxMedia.SuspendLayout();
			this.menuStripMain.SuspendLayout();
			this.groupBoxDuplicates.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartCounter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPadLength)).BeginInit();
			this.SuspendLayout();
			// 
			// openFileDialogXML
			// 
			this.openFileDialogXML.DefaultExt = "xml";
			this.openFileDialogXML.Filter = "Extensible Markup Language files|*.xml";
			this.openFileDialogXML.Multiselect = true;
			// 
			// buttonSelectFiles
			// 
			this.buttonSelectFiles.Location = new System.Drawing.Point(12, 42);
			this.buttonSelectFiles.Name = "buttonSelectFiles";
			this.buttonSelectFiles.Size = new System.Drawing.Size(108, 23);
			this.buttonSelectFiles.TabIndex = 0;
			this.buttonSelectFiles.Text = "Select Files...";
			this.buttonSelectFiles.UseVisualStyleBackColor = true;
			this.buttonSelectFiles.Click += new System.EventHandler(this.buttonParse_Click);
			// 
			// checkBoxLog
			// 
			this.checkBoxLog.AutoSize = true;
			this.checkBoxLog.Location = new System.Drawing.Point(6, 19);
			this.checkBoxLog.Name = "checkBoxLog";
			this.checkBoxLog.Size = new System.Drawing.Size(104, 17);
			this.checkBoxLog.TabIndex = 1;
			this.checkBoxLog.Text = "Generate Logfile";
			this.checkBoxLog.UseVisualStyleBackColor = true;
			this.checkBoxLog.CheckedChanged += new System.EventHandler(this.checkBoxLog_CheckedChanged);
			// 
			// groupBoxLogging
			// 
			this.groupBoxLogging.Controls.Add(this.comboBoxVerbosity);
			this.groupBoxLogging.Controls.Add(this.labelVerbosity);
			this.groupBoxLogging.Controls.Add(this.checkBoxLog);
			this.groupBoxLogging.Location = new System.Drawing.Point(22, 289);
			this.groupBoxLogging.Name = "groupBoxLogging";
			this.groupBoxLogging.Size = new System.Drawing.Size(432, 67);
			this.groupBoxLogging.TabIndex = 2;
			this.groupBoxLogging.TabStop = false;
			this.groupBoxLogging.Text = "Logging";
			// 
			// comboBoxVerbosity
			// 
			this.comboBoxVerbosity.FormattingEnabled = true;
			this.comboBoxVerbosity.Location = new System.Drawing.Point(66, 40);
			this.comboBoxVerbosity.Name = "comboBoxVerbosity";
			this.comboBoxVerbosity.Size = new System.Drawing.Size(229, 21);
			this.comboBoxVerbosity.TabIndex = 3;
			// 
			// labelVerbosity
			// 
			this.labelVerbosity.AutoSize = true;
			this.labelVerbosity.Location = new System.Drawing.Point(7, 43);
			this.labelVerbosity.Name = "labelVerbosity";
			this.labelVerbosity.Size = new System.Drawing.Size(53, 13);
			this.labelVerbosity.TabIndex = 2;
			this.labelVerbosity.Text = "Verbosity:";
			// 
			// listBoxFileNames
			// 
			this.listBoxFileNames.FormattingEnabled = true;
			this.listBoxFileNames.Location = new System.Drawing.Point(126, 42);
			this.listBoxFileNames.Name = "listBoxFileNames";
			this.listBoxFileNames.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.listBoxFileNames.Size = new System.Drawing.Size(328, 121);
			this.listBoxFileNames.TabIndex = 3;
			// 
			// buttonSelectDestination
			// 
			this.buttonSelectDestination.Location = new System.Drawing.Point(10, 42);
			this.buttonSelectDestination.Name = "buttonSelectDestination";
			this.buttonSelectDestination.Size = new System.Drawing.Size(110, 23);
			this.buttonSelectDestination.TabIndex = 4;
			this.buttonSelectDestination.Text = "Select Destination...";
			this.buttonSelectDestination.UseVisualStyleBackColor = true;
			this.buttonSelectDestination.Click += new System.EventHandler(this.buttonSelectDestination_Click);
			// 
			// textBoxDestination
			// 
			this.textBoxDestination.Location = new System.Drawing.Point(82, 71);
			this.textBoxDestination.Name = "textBoxDestination";
			this.textBoxDestination.Size = new System.Drawing.Size(358, 20);
			this.textBoxDestination.TabIndex = 5;
			// 
			// buttonStart
			// 
			this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonStart.Location = new System.Drawing.Point(797, 364);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(113, 37);
			this.buttonStart.TabIndex = 6;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// groupBoxDestination
			// 
			this.groupBoxDestination.Controls.Add(this.labelDestination);
			this.groupBoxDestination.Controls.Add(this.radioButtonDestinationCustom);
			this.groupBoxDestination.Controls.Add(this.radioButtonDestinationSource);
			this.groupBoxDestination.Controls.Add(this.buttonSelectDestination);
			this.groupBoxDestination.Controls.Add(this.textBoxDestination);
			this.groupBoxDestination.Location = new System.Drawing.Point(470, 42);
			this.groupBoxDestination.Name = "groupBoxDestination";
			this.groupBoxDestination.Size = new System.Drawing.Size(446, 129);
			this.groupBoxDestination.TabIndex = 7;
			this.groupBoxDestination.TabStop = false;
			this.groupBoxDestination.Text = "Destination";
			// 
			// labelDestination
			// 
			this.labelDestination.AutoSize = true;
			this.labelDestination.Location = new System.Drawing.Point(11, 74);
			this.labelDestination.Name = "labelDestination";
			this.labelDestination.Size = new System.Drawing.Size(63, 13);
			this.labelDestination.TabIndex = 8;
			this.labelDestination.Text = "Destination:";
			// 
			// radioButtonDestinationCustom
			// 
			this.radioButtonDestinationCustom.AutoSize = true;
			this.radioButtonDestinationCustom.Location = new System.Drawing.Point(147, 19);
			this.radioButtonDestinationCustom.Name = "radioButtonDestinationCustom";
			this.radioButtonDestinationCustom.Size = new System.Drawing.Size(114, 17);
			this.radioButtonDestinationCustom.TabIndex = 7;
			this.radioButtonDestinationCustom.Text = "Custom destination";
			this.radioButtonDestinationCustom.UseVisualStyleBackColor = true;
			this.radioButtonDestinationCustom.CheckedChanged += new System.EventHandler(this.radioButtonDestination_CheckedChanged);
			// 
			// radioButtonDestinationSource
			// 
			this.radioButtonDestinationSource.AutoSize = true;
			this.radioButtonDestinationSource.Location = new System.Drawing.Point(10, 19);
			this.radioButtonDestinationSource.Name = "radioButtonDestinationSource";
			this.radioButtonDestinationSource.Size = new System.Drawing.Size(131, 17);
			this.radioButtonDestinationSource.TabIndex = 6;
			this.radioButtonDestinationSource.Text = "Inside source directory";
			this.radioButtonDestinationSource.UseVisualStyleBackColor = true;
			this.radioButtonDestinationSource.CheckedChanged += new System.EventHandler(this.radioButtonDestination_CheckedChanged);
			// 
			// groupBoxMedia
			// 
			this.groupBoxMedia.Controls.Add(this.checkBoxRenameMedia);
			this.groupBoxMedia.Location = new System.Drawing.Point(470, 178);
			this.groupBoxMedia.Name = "groupBoxMedia";
			this.groupBoxMedia.Size = new System.Drawing.Size(446, 67);
			this.groupBoxMedia.TabIndex = 8;
			this.groupBoxMedia.TabStop = false;
			this.groupBoxMedia.Text = "Media Dates";
			// 
			// checkBoxRenameMedia
			// 
			this.checkBoxRenameMedia.AutoSize = true;
			this.checkBoxRenameMedia.Location = new System.Drawing.Point(10, 19);
			this.checkBoxRenameMedia.Name = "checkBoxRenameMedia";
			this.checkBoxRenameMedia.Size = new System.Drawing.Size(332, 17);
			this.checkBoxRenameMedia.TabIndex = 0;
			this.checkBoxRenameMedia.Text = "Change published dates to upload dates to preserve file structure";
			this.checkBoxRenameMedia.UseVisualStyleBackColor = true;
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(928, 24);
			this.menuStripMain.TabIndex = 9;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.helpToolStripMenuItem1.Text = "Help...";
			this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// groupBoxDuplicates
			// 
			this.groupBoxDuplicates.Controls.Add(this.labelPreview);
			this.groupBoxDuplicates.Controls.Add(this.numericUpDownPadLength);
			this.groupBoxDuplicates.Controls.Add(this.label2);
			this.groupBoxDuplicates.Controls.Add(this.numericUpDownStartCounter);
			this.groupBoxDuplicates.Controls.Add(this.label1);
			this.groupBoxDuplicates.Controls.Add(this.labelOrdinal);
			this.groupBoxDuplicates.Controls.Add(this.textBoxSeparationCharacter);
			this.groupBoxDuplicates.Controls.Add(this.labelOriginalName);
			this.groupBoxDuplicates.Controls.Add(this.labelSeparationCharacterDesc);
			this.groupBoxDuplicates.Controls.Add(this.checkBoxRenameDuplicates);
			this.groupBoxDuplicates.Location = new System.Drawing.Point(22, 178);
			this.groupBoxDuplicates.Name = "groupBoxDuplicates";
			this.groupBoxDuplicates.Size = new System.Drawing.Size(432, 105);
			this.groupBoxDuplicates.TabIndex = 10;
			this.groupBoxDuplicates.TabStop = false;
			this.groupBoxDuplicates.Text = "Duplicate Renamer";
			// 
			// checkBoxRenameDuplicates
			// 
			this.checkBoxRenameDuplicates.AutoSize = true;
			this.checkBoxRenameDuplicates.Location = new System.Drawing.Point(7, 20);
			this.checkBoxRenameDuplicates.Name = "checkBoxRenameDuplicates";
			this.checkBoxRenameDuplicates.Size = new System.Drawing.Size(238, 17);
			this.checkBoxRenameDuplicates.TabIndex = 0;
			this.checkBoxRenameDuplicates.Text = "Rename posts and media with duplicate titles";
			this.checkBoxRenameDuplicates.UseVisualStyleBackColor = true;
			this.checkBoxRenameDuplicates.CheckedChanged += new System.EventHandler(this.checkBoxRenameDuplicates_CheckedChanged);
			// 
			// labelSeparationCharacterDesc
			// 
			this.labelSeparationCharacterDesc.AutoSize = true;
			this.labelSeparationCharacterDesc.Location = new System.Drawing.Point(7, 43);
			this.labelSeparationCharacterDesc.Name = "labelSeparationCharacterDesc";
			this.labelSeparationCharacterDesc.Size = new System.Drawing.Size(120, 13);
			this.labelSeparationCharacterDesc.TabIndex = 1;
			this.labelSeparationCharacterDesc.Text = "Separation character(s):";
			// 
			// labelOriginalName
			// 
			this.labelOriginalName.AutoSize = true;
			this.labelOriginalName.Location = new System.Drawing.Point(133, 43);
			this.labelOriginalName.Name = "labelOriginalName";
			this.labelOriginalName.Size = new System.Drawing.Size(82, 13);
			this.labelOriginalName.TabIndex = 2;
			this.labelOriginalName.Text = "Original Name +";
			// 
			// textBoxSeparationCharacter
			// 
			this.textBoxSeparationCharacter.Location = new System.Drawing.Point(221, 40);
			this.textBoxSeparationCharacter.Name = "textBoxSeparationCharacter";
			this.textBoxSeparationCharacter.Size = new System.Drawing.Size(44, 20);
			this.textBoxSeparationCharacter.TabIndex = 3;
			this.textBoxSeparationCharacter.Text = "_";
			// 
			// labelOrdinal
			// 
			this.labelOrdinal.AutoSize = true;
			this.labelOrdinal.Location = new System.Drawing.Point(272, 43);
			this.labelOrdinal.Name = "labelOrdinal";
			this.labelOrdinal.Size = new System.Drawing.Size(13, 13);
			this.labelOrdinal.TabIndex = 4;
			this.labelOrdinal.Text = "+";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Start counting at: ";
			// 
			// numericUpDownStartCounter
			// 
			this.numericUpDownStartCounter.Location = new System.Drawing.Point(107, 69);
			this.numericUpDownStartCounter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownStartCounter.Name = "numericUpDownStartCounter";
			this.numericUpDownStartCounter.Size = new System.Drawing.Size(52, 20);
			this.numericUpDownStartCounter.TabIndex = 6;
			this.numericUpDownStartCounter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDownStartCounter.ValueChanged += new System.EventHandler(this.Preview_ValueChanged);
			// 
			// numericUpDownPadLength
			// 
			this.numericUpDownPadLength.Location = new System.Drawing.Point(253, 69);
			this.numericUpDownPadLength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownPadLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownPadLength.Name = "numericUpDownPadLength";
			this.numericUpDownPadLength.Size = new System.Drawing.Size(52, 20);
			this.numericUpDownPadLength.TabIndex = 8;
			this.numericUpDownPadLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownPadLength.ValueChanged += new System.EventHandler(this.Preview_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(174, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Pad to length:";
			// 
			// labelPreview
			// 
			this.labelPreview.AutoSize = true;
			this.labelPreview.Location = new System.Drawing.Point(282, 43);
			this.labelPreview.Name = "labelPreview";
			this.labelPreview.Size = new System.Drawing.Size(13, 13);
			this.labelPreview.TabIndex = 9;
			this.labelPreview.Text = "2";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(928, 422);
			this.Controls.Add(this.groupBoxDuplicates);
			this.Controls.Add(this.groupBoxMedia);
			this.Controls.Add(this.groupBoxDestination);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.listBoxFileNames);
			this.Controls.Add(this.groupBoxLogging);
			this.Controls.Add(this.buttonSelectFiles);
			this.Controls.Add(this.menuStripMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripMain;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WordPress Export File Improver";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBoxLogging.ResumeLayout(false);
			this.groupBoxLogging.PerformLayout();
			this.groupBoxDestination.ResumeLayout(false);
			this.groupBoxDestination.PerformLayout();
			this.groupBoxMedia.ResumeLayout(false);
			this.groupBoxMedia.PerformLayout();
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.groupBoxDuplicates.ResumeLayout(false);
			this.groupBoxDuplicates.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartCounter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPadLength)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialogXML;
		private System.Windows.Forms.Button buttonSelectFiles;
		private System.Windows.Forms.CheckBox checkBoxLog;
		private System.Windows.Forms.GroupBox groupBoxLogging;
		private System.Windows.Forms.Label labelVerbosity;
		private System.Windows.Forms.ComboBox comboBoxVerbosity;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestination;
		private System.Windows.Forms.ListBox listBoxFileNames;
		private System.Windows.Forms.Button buttonSelectDestination;
		private System.Windows.Forms.TextBox textBoxDestination;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.GroupBox groupBoxDestination;
		private System.Windows.Forms.RadioButton radioButtonDestinationSource;
		private System.Windows.Forms.RadioButton radioButtonDestinationCustom;
		private System.Windows.Forms.Label labelDestination;
		private System.Windows.Forms.GroupBox groupBoxMedia;
		private System.Windows.Forms.CheckBox checkBoxRenameMedia;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBoxDuplicates;
		private System.Windows.Forms.CheckBox checkBoxRenameDuplicates;
		private System.Windows.Forms.Label labelSeparationCharacterDesc;
		private System.Windows.Forms.Label labelOriginalName;
		private System.Windows.Forms.TextBox textBoxSeparationCharacter;
		private System.Windows.Forms.Label labelOrdinal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownStartCounter;
		private System.Windows.Forms.NumericUpDown numericUpDownPadLength;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelPreview;
	}
}


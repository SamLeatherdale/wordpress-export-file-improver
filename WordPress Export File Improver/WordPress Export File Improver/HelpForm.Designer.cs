namespace WordPress_Duplicate_Resolver
{
	partial class HelpForm
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
			this.listBoxTopics = new System.Windows.Forms.ListBox();
			this.textBoxHelpText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listBoxTopics
			// 
			this.listBoxTopics.FormattingEnabled = true;
			this.listBoxTopics.Location = new System.Drawing.Point(13, 13);
			this.listBoxTopics.Name = "listBoxTopics";
			this.listBoxTopics.Size = new System.Drawing.Size(120, 95);
			this.listBoxTopics.TabIndex = 0;
			this.listBoxTopics.SelectedIndexChanged += new System.EventHandler(this.listBoxTopics_SelectedIndexChanged);
			// 
			// textBoxHelpText
			// 
			this.textBoxHelpText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxHelpText.Location = new System.Drawing.Point(140, 13);
			this.textBoxHelpText.Multiline = true;
			this.textBoxHelpText.Name = "textBoxHelpText";
			this.textBoxHelpText.ReadOnly = true;
			this.textBoxHelpText.Size = new System.Drawing.Size(332, 286);
			this.textBoxHelpText.TabIndex = 1;
			// 
			// HelpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 311);
			this.Controls.Add(this.textBoxHelpText);
			this.Controls.Add(this.listBoxTopics);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "HelpForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Help...";
			this.Load += new System.EventHandler(this.HelpForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxTopics;
		private System.Windows.Forms.TextBox textBoxHelpText;
	}
}
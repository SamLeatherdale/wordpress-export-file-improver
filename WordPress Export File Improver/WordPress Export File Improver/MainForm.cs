using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace WordPress_Duplicate_Resolver
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void buttonParse_Click(object sender, EventArgs e)
		{
			if (openFileDialogXML.ShowDialog() == DialogResult.OK)
			{
				foreach (string filename in openFileDialogXML.SafeFileNames)
				{
					listBoxFileNames.Items.Add(filename);
				}
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			comboBoxVerbosity.Items.Add(new DisplayItem("0: List each duplicate/date entry once", 0));
			comboBoxVerbosity.Items.Add(new DisplayItem("1: List every duplicate replacement made", 1));
			comboBoxVerbosity.Items.Add(new DisplayItem("2: List every date replacement made", 2));
			comboBoxVerbosity.DisplayMember = "DisplayMember";
			comboBoxVerbosity.ValueMember = "ValueMember";
			comboBoxVerbosity.SelectedIndex = 0;
			radioButtonDestinationSource.Checked = true;
			checkBoxLog.Checked = true;
			checkBoxRenameDuplicates.Checked = true;
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			string directory;
			bool createLog = checkBoxLog.Checked;
			bool renameDuplicates = checkBoxRenameDuplicates.Checked;
			bool renameMedia = checkBoxRenameMedia.Checked;
			int startCounter = (int)numericUpDownStartCounter.Value;
			string separationCharacter = textBoxSeparationCharacter.Text;
			string ordinalFormatString = "D" + numericUpDownPadLength.Value.ToString();
			int verbosity = (int)((DisplayItem)comboBoxVerbosity.SelectedItem).ValueMember;
			StreamWriter log = null;


			if (openFileDialogXML.FileNames.Length == 0)
			{
				MessageBox.Show("Please select files to refactor.","No files selected",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			if (radioButtonDestinationCustom.Checked && textBoxDestination.Text.Trim() == "")
			{
				MessageBox.Show("Please select a destination.","No destination selected",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			if (!renameDuplicates && !renameMedia)
			{
				MessageBox.Show("The program has nothing to do! Please select an operation.", "No operation selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (radioButtonDestinationCustom.Checked)
			{
				directory = textBoxDestination.Text;
			}
			else
			{
				directory = Path.Combine(Path.GetDirectoryName(openFileDialogXML.FileName), "FIXED");
			}
			if (!Directory.Exists(directory))
			{
				try
				{
					Directory.CreateDirectory(directory);
				}
				catch (Exception) {
					MessageBox.Show("Invalid destination directory.","Invalid destination",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}				
			}
			if (createLog)
			{
				log = new StreamWriter(Path.Combine(directory, "log.txt"), false);
			}
			Dictionary<string, int> titles = new Dictionary<string, int>();
			Dictionary<string, int> dates = new Dictionary<string, int>();
			Regex dateLinkUrl = new Regex("^https?://[^/]+/([0-9]+)/([0-9]+)/([0-9]+)/.+$");
			Regex dateGuidUrl = new Regex("^https?://[^/]+/([0-9]+)/([0-9]+)/.+$");
			//Begin refactoring
			foreach (string filename in openFileDialogXML.FileNames)
			{
				if (createLog)
				{
					log.WriteLine();
					log.WriteLine(string.Concat(Enumerable.Repeat("--", 40)));
					log.WriteLine("File " + filename);
					log.WriteLine(string.Concat(Enumerable.Repeat("--", 40)));
				}
				XmlDocument doc = new XmlDocument();
				doc.PreserveWhitespace = true;
				doc.Load(filename);
				XmlNodeList itemNodes = doc.GetElementsByTagName("item");
				foreach (XmlNode itemNode in itemNodes)
				{
					ItemNode item = new ItemNode();
					//Serialize
					foreach (XmlNode childNode in itemNode.ChildNodes)
					{
						if (childNode.Name == "title")
						{
							item.titleNode = childNode;
						}
						else if (childNode.Name == "link")
						{
							item.linkNode = childNode;
						}
						else if (childNode.Name == "pubDate")
						{
							item.pubDateNode = childNode;
						}
						else if (childNode.Name == "wp:post_date")
						{
							item.postDateNode = childNode;
						}
						else if (childNode.Name == "wp:post_date_gmt")
						{
							item.postDateGmtNode = childNode;
						}
						else if (childNode.Name == "wp:attachment_url")
						{
							item.attachmentUrlNode = childNode;
						}
					}

					//Deal with titles
					if (renameDuplicates)
					{
						if (item.titleNode != null && item.titleNode.InnerText != "")
						{
							string base_title = item.titleNode.InnerText;
							if (titles.ContainsKey(base_title))
							{
								titles[base_title]++;
								string ordinal = titles[base_title].ToString(ordinalFormatString);
								string replacementText = base_title + separationCharacter + ordinal;
								if (createLog)
								{
									if (verbosity >= 1)
									{
										log.WriteLine("Replacing \"" + base_title + "\" with \"" + replacementText + "\"");
									}
									else if (verbosity == 0 && titles[base_title] == startCounter)
									{
										log.WriteLine("Found Duplicate:\t\"" + base_title + "\"");
									}
								}
								item.titleNode.InnerText = replacementText;
							}
							else
							{
								titles.Add(base_title, startCounter - 1);
							}
						}
					}										
					//Deal with media
					if (renameMedia && item.attachmentUrlNode != null)
					{
						string originalDate = item.postDateNode.InnerText.Substring(0, 10);
						DateTime uploadDate = new DateTime();
						bool updateDate = true;
						//Try link url for more accurate date
						GroupCollection dateParts = dateLinkUrl.Match(item.linkNode.InnerText).Groups;
						if (dateParts.Count == 4)
						{
							uploadDate = new DateTime(int.Parse(dateParts[1].Value), int.Parse(dateParts[2].Value), int.Parse(dateParts[3].Value));
						}
						else
						{
							//Try guid url for year and month
							dateParts = dateGuidUrl.Match(item.linkNode.InnerText).Groups;
							if (dateParts.Count == 3)
							{
								uploadDate = new DateTime(int.Parse(dateParts[1].Value), int.Parse(dateParts[2].Value),1);
							}
							else
							{
								//Don't update the date
								updateDate = false;
							}
						}
						if (updateDate)
						{
							item.pubDateNode.InnerText = uploadDate.ToString(@"ddd, dd MMM yyyy 00\:00\:00 +0000");
							item.postDateNode.InnerText = uploadDate.ToString(@"yyyy-MM-dd 00\:00\:00");
							item.postDateGmtNode.InnerText = uploadDate.ToString(@"yyyy-MM-dd 00\:00\:00");
							if (createLog)
							{
								string dateLog = "Replaced " + originalDate + " with " + uploadDate.ToString("yyyy-MM-dd");
								if (dates.ContainsKey(dateLog))
								{
									dates[dateLog]++;
								}
								else
								{
									dates.Add(dateLog, 1);
								}
								if (verbosity >= 2)
								{
									log.WriteLine(dates[dateLog].ToString() + "-th time replacing " + originalDate + " with " + uploadDate.ToString("yyyy-MM-dd"));
								}
								else if (verbosity >= 0 && dates[dateLog] == 1)
								{
									log.WriteLine(dateLog);
								}
							}
						}						
					}
				}//End item loop
				string path = Path.Combine(directory,Path.GetFileNameWithoutExtension(filename) + "-FIXED" + Path.GetExtension(filename));
				doc.Save(path);
			}//End document loop

			if (createLog)
			{
				log.WriteLine();
				log.WriteLine(string.Concat(Enumerable.Repeat("**", 40)));
				log.WriteLine("SUMMARY OF CHANGES MADE");
				log.WriteLine(string.Concat(Enumerable.Repeat("**", 40)));
				int compareStart = 1 - startCounter;
				foreach (KeyValuePair<string, int> title in titles)
				{
					if (title.Value > 1)
					{
						log.WriteLine("\"" + title.Key + "\" was replaced " + (title.Value + compareStart).ToString() + " times");
					}
				}
				foreach (KeyValuePair<string, int> date in dates)
				{
					log.WriteLine(date.Key + "\t\t" + date.Value.ToString() + " times");
				}
			}
			log.Close();
			System.Diagnostics.Process.Start(directory);
			MessageBox.Show("Operations complete.", "Operations complete",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void buttonSelectDestination_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialogDestination.ShowDialog() == DialogResult.OK)
			{
				textBoxDestination.Text = folderBrowserDialogDestination.SelectedPath;
			}
		}

		private void radioButtonDestination_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonDestinationCustom.Checked)
			{
				textBoxDestination.Enabled = true;
				buttonSelectDestination.Enabled = true;
			}
			else
			{
				textBoxDestination.Enabled = false;
				buttonSelectDestination.Enabled = false;
			}
		}

		private void checkBoxLog_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxLog.Checked)
			{
				comboBoxVerbosity.Enabled = true;
			}
			else
			{
				comboBoxVerbosity.Enabled = false;
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox aboutBox = new AboutBox();
			aboutBox.ShowDialog();
		}

		private void checkBoxRenameDuplicates_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxRenameDuplicates.Checked)
			{
				textBoxSeparationCharacter.Enabled = true;
				numericUpDownStartCounter.Enabled = true;
				numericUpDownPadLength.Enabled = true;
			}
			else
			{
				textBoxSeparationCharacter.Enabled = false;
				numericUpDownStartCounter.Enabled = false;
				numericUpDownPadLength.Enabled = false;
			}
		}

		private void Preview_ValueChanged(object sender, EventArgs e)
		{
			string formatString = "D" + numericUpDownPadLength.Value.ToString();
			labelPreview.Text = ((int)numericUpDownStartCounter.Value).ToString(formatString);
		}

		private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			HelpForm helpForm = new HelpForm();
			helpForm.ShowDialog();
		}
	}
}

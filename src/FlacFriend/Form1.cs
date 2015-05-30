using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace FlacFriend
{
    public partial class Form1 : Form
    {
        public static readonly Color ChangedColor = Color.Yellow;
        public List<string> Folders = new List<string>();
        private int _currentFolderIndex = -1;
        
        public int CurrentFolderIndex
        {
            get
            {
                if (_currentFolderIndex == -1)
                {
                    SetCurrentFolderIndex();
                }

                return _currentFolderIndex;
            }
            set { _currentFolderIndex = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void SetCurrentFolderIndex()
        {
            _currentFolderIndex = Folders.IndexOf(labelSourceFoloder.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sourceFolderBrowser.ShowDialog();
            SetSourceFolder(sourceFolderBrowser.SelectedPath);
            Folders.Clear();
            Folders.AddRange(System.IO.Directory.GetDirectories(System.IO.Path.GetDirectoryName(sourceFolderBrowser.SelectedPath)));
            SetCurrentFolderIndex();
        }

        private void SetSourceFolder(string path)
        {
            textBoxArtist.ResetText();
            textBoxAlbum.ResetText();
            textBoxYear.ResetText();
            textBoxGenre.ResetText();

            labelSourceFoloder.Text = path;
            labelFolderName.Text = System.IO.Path.GetFileName(path);
            labelFolderName.BackColor = Color.Transparent;

            var table = new DataTable();
            table.Columns.Add(Columns.Path);
            table.Columns.Add(Columns.FileName);
            table.Columns.Add(Columns.Artist);
            table.Columns.Add(Columns.Album);
            table.Columns.Add(Columns.TrackNo);
            table.Columns.Add(Columns.Title);
            table.Columns.Add(Columns.Year);
            table.Columns.Add(Columns.Genre);
            table.Columns.Add(Columns.Disc);

            var files = new System.IO.DirectoryInfo(path).GetFiles("*.flac");
            if (!files.Any())
            {
                files = new System.IO.DirectoryInfo(path).GetFiles("*.flac", SearchOption.AllDirectories);
            }

            foreach (var fileInfo in files)
            {
                var row = table.NewRow();

                using (var file = TagLib.File.Create(fileInfo.FullName))
                {
                    row[Columns.Path] = fileInfo.FullName;
                    row[Columns.FileName] = fileInfo.Name;
                    row[Columns.Artist] = file.Tag.FirstPerformer;
                    row[Columns.Album] = file.Tag.Album;
                    row[Columns.TrackNo] = file.Tag.Track;
                    row[Columns.Title] = file.Tag.Title;
                    row[Columns.Year] = file.Tag.Year;
                    row[Columns.Genre] = file.Tag.FirstGenre;

                    if (string.IsNullOrEmpty(textBoxArtist.Text))
                    {
                        textBoxArtist.Text = row[Columns.Artist].ToString();
                    }

                    if (string.IsNullOrEmpty(textBoxAlbum.Text))
                    {
                        string album = Regex.Replace(row[Columns.Album].ToString(), " \\(Disc [0-9]*\\)", "");
                        textBoxAlbum.Text = album;
                    }

                    if (string.IsNullOrEmpty(textBoxYear.Text))
                    {
                        textBoxYear.Text = row[Columns.Year].ToString();
                    }

                    if (string.IsNullOrEmpty(textBoxGenre.Text))
                    {
                        textBoxGenre.Text = row[Columns.Genre].ToString();
                    }

                    if (fileInfo.DirectoryName != path)
                    {
                        string folderName = System.IO.Path.GetFileName(fileInfo.DirectoryName);
                        string match = System.Text.RegularExpressions.Regex.Match(folderName, @"\d+").Value;
                        uint disc;
                        if (!string.IsNullOrEmpty(match) && uint.TryParse(match, out disc))
                        {
                            row[Columns.Disc] = disc;
                        }
                    }
                }

                table.Rows.Add(row);
            }

            dataGridFiles.DataSource = table;
        }

        private void buttonTargetFoloder_Click(object sender, EventArgs e)
        {
            targetFolderBrowser.ShowDialog();
            labelTargetFolder.Text = targetFolderBrowser.SelectedPath;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridFiles.Rows)
            {
                TagLib.File file = null;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Style.BackColor == ChangedColor)
                    {
                        if (file == null)
                        {
                            file = TagLib.File.Create(row.Cells[Columns.Path].Value.ToString());
                        }

                        switch (cell.OwningColumn.Name)
                        {
                            case Columns.Artist:
                                file.Tag.Performers = new [] {cell.Value.ToString()};
                                cell.Style.BackColor = Color.White;
                                break;
                            case Columns.Album:
                                file.Tag.Album = cell.Value.ToString();
                                cell.Style.BackColor = Color.White;
                                break;
                            case Columns.TrackNo:
                                uint trackNo;
                                if (uint.TryParse(cell.Value.ToString(), out trackNo))
                                {
                                    file.Tag.Track = trackNo;
                                    cell.Style.BackColor = Color.White;
                                }
                                break;
                            case Columns.Title:
                                file.Tag.Title = cell.Value.ToString();
                                cell.Style.BackColor = Color.White;
                                break;
                            case Columns.Year:
                                uint year;
                                if (uint.TryParse(cell.Value.ToString(), out year))
                                {
                                    file.Tag.Year = year;
                                    cell.Style.BackColor = Color.White;
                                }
                                break;
                            case Columns.Genre:
                                file.Tag.Genres = new [] { cell.Value.ToString()};
                                cell.Style.BackColor = Color.White;
                                break;
                        }
                    }
                }

                if (file != null)
                {
                    file.Save();
                    file.Dispose();
                }
            }
        }

        private void dataGridFiles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            if (e.RowIndex > -1)
            {
                grid[e.ColumnIndex, e.RowIndex].Style.BackColor = ChangedColor;
            }
        }

        private void buttonNextFolder_Click(object sender, EventArgs e)
        {
            int nextIndex = CurrentFolderIndex < Folders.Count - 1 ? CurrentFolderIndex + 1 : 0;

            int nextPathIndex = Folders.FindIndex(nextIndex, Directory.Exists);

            string nextPath = Folders[nextPathIndex];
            CurrentFolderIndex = nextPathIndex;

            SetSourceFolder(nextPath);
        }

        private void buttonPreviousFolder_Click(object sender, EventArgs e)
        {
            int nextIndex = CurrentFolderIndex > 0 ? CurrentFolderIndex - 1 : Folders.Count - 1;

            int nextPathIndex = Folders.FindLastIndex(0, nextIndex + 1, Directory.Exists);

            string nextPath = Folders[nextPathIndex];
            CurrentFolderIndex = nextPathIndex;

            SetSourceFolder(nextPath);
        }

        private void SetTagsFromTextBox(TextBox textBox, string column)
        {
            foreach (DataGridViewRow row in dataGridFiles.Rows)
            {
                var cell = row.Cells[column];
                cell.Value = textBox.Text;
                cell.Style.BackColor = ChangedColor;
            }
        }

        private void textBoxArtist_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            SetTagsFromTextBox(textBox, Columns.Artist);
        }

        private void textBoxAlbum_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;

            foreach (DataGridViewRow row in dataGridFiles.Rows)
            {
                var cell = row.Cells[Columns.Album];
                string disc = row.Cells[Columns.Disc].Value.ToString();
                cell.Value = string.IsNullOrEmpty(disc) ? textBox.Text : string.Format("{0} (Disc {1})", textBox.Text, disc);
                cell.Style.BackColor = ChangedColor;


                if (row.Index == 0)
                {
                    string oldFolderName = System.IO.Path.GetFileName(labelSourceFoloder.Text);

                    string newFolderName = string.Format("{0} - {1}", row.Cells["Artist"].Value, textBox.Text);

                    labelFolderName.Text = newFolderName;
                    if (newFolderName != oldFolderName)
                    {
                        labelFolderName.BackColor = ChangedColor;
                    }
                    else
                    {
                        labelFolderName.BackColor = Color.Transparent;
                    }
                }
            }
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            SetTagsFromTextBox(textBox, Columns.Year);
        }

        private void textBoxGenre_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            SetTagsFromTextBox(textBox, Columns.Genre);
        }

        private void buttonGetFileNamesFromTags_Click(object sender, EventArgs e)
        {
            Regex invalidFileNameChars = new Regex("["+ Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars())) + "]", RegexOptions.Compiled);

            foreach (DataGridViewRow row in dataGridFiles.Rows)
            {
                if (row.Index == 0)
                {
                    string folderName = string.Format("{0} - {1}", row.Cells[Columns.Artist].Value, row.Cells[Columns.Album].Value);
                    folderName = invalidFileNameChars.Replace(folderName, "");

                    folderName = Regex.Replace(folderName, " \\(Disc [0-9]*\\)", "");

                    if (labelFolderName.Text != folderName)
                    {
                        labelFolderName.Text = folderName;
                        labelFolderName.BackColor = ChangedColor;
                    }
                }

                var cell = row.Cells[Columns.FileName];

                uint trackNo;
                if (uint.TryParse(row.Cells[Columns.TrackNo].Value.ToString(), out trackNo))
                {
                    string fileName = string.Format("{0} - {1} - {2} - {3}.flac", row.Cells[Columns.Artist].Value, row.Cells[Columns.Album].Value, trackNo.ToString("00"), row.Cells[Columns.Title].Value);
                    string oldFieName = cell.Value.ToString();
                    fileName = invalidFileNameChars.Replace(fileName, "");

                    if (fileName != oldFieName)
                    {
                        cell.Value = fileName;
                        cell.Style.BackColor = ChangedColor;
                    }
                }
            }
        }

        private void buttonSaveFileNames_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> discFolders = new Dictionary<string, string>();

            foreach (DataGridViewRow row in dataGridFiles.Rows)
            {
                var fileNameCell = row.Cells[Columns.FileName];

                if (fileNameCell.Style.BackColor == ChangedColor)
                {
                    var pathCell = row.Cells[Columns.Path];

                    string path = pathCell.Value.ToString();
                    string folder = System.IO.Path.GetDirectoryName(path);

                    string newPath = System.IO.Path.Combine(folder, fileNameCell.Value.ToString());
                    FileSystem.Rename(path, newPath);

                    string disc = row.Cells[Columns.Disc].Value.ToString();
                    if (!string.IsNullOrEmpty(disc) && folder != labelSourceFoloder.Text && !discFolders.ContainsKey(folder))
                    {
                        discFolders.Add(folder, disc);
                    }
                    
                    pathCell.Value = newPath;
                    fileNameCell.Style.BackColor = Color.White;
                }
            }

            foreach (KeyValuePair<string, string> discFolder in discFolders)
            {
                string newFolder = System.IO.Path.Combine(labelSourceFoloder.Text, string.Format("Disc {0}", discFolder.Value));
                if (discFolder.Key.ToLower() != newFolder.ToLower())
                {
                    FileSystem.Rename(discFolder.Key, newFolder);
                }
            }

            if (labelFolderName.BackColor == ChangedColor)
            {
                string folder = System.IO.Path.GetDirectoryName(labelSourceFoloder.Text);
                string newPath = System.IO.Path.Combine(folder, labelFolderName.Text);
                
                FileSystem.Rename(labelSourceFoloder.Text, newPath);
                labelFolderName.BackColor = Color.Transparent;

                SetSourceFolder(newPath);
            }
            else if (discFolders.Count > 0)
            {
                SetSourceFolder(labelSourceFoloder.Text);
            }
            
        }

        private void buttonGetTagsFromFileName_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridFiles.Rows)
            {
                string fileName = row.Cells[Columns.FileName].Value.ToString();

                string match = System.Text.RegularExpressions.Regex.Match(fileName, @"\d+").Value;
                uint trackNo;
                if (!string.IsNullOrEmpty(match) && uint.TryParse(match, out trackNo))
                {
                    row.Cells[Columns.TrackNo].Value = trackNo;
                }

                match = Regex.Match(fileName, @"[A-Za-z][A-Za-z ',()]+").Value;
                if (!string.IsNullOrEmpty(match))
                {
                    row.Cells[Columns.Title].Value = match;
                }


            }
        }

        private void buttonMoveToTargetFolder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(targetFolderBrowser.SelectedPath))
            {
                try
                {
                    string newFolder = System.IO.Path.Combine(targetFolderBrowser.SelectedPath, labelFolderName.Text);

                    Directory.Move(labelSourceFoloder.Text, newFolder);
                    SetSourceFolder(newFolder);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("No output selected.", "Error");
            }
        }

        private void buttonCapitalizeTitles_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridFiles.Rows)
            {
                string title = row.Cells[Columns.Title].Value.ToString();

                title = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(title);

                row.Cells[Columns.Title].Value = title;
            }
        }
    }
}
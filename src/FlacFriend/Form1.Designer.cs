namespace FlacFriend
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sourceFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSourceFolder = new System.Windows.Forms.Button();
            this.labelSourceFoloder = new System.Windows.Forms.Label();
            this.buttonTargetFoloder = new System.Windows.Forms.Button();
            this.labelTargetFolder = new System.Windows.Forms.Label();
            this.targetFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonPreviousFolder = new System.Windows.Forms.Button();
            this.buttonNextFolder = new System.Windows.Forms.Button();
            this.dataGridFiles = new System.Windows.Forms.DataGridView();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGetFileNamesFromTags = new System.Windows.Forms.Button();
            this.labelFolderName = new System.Windows.Forms.Label();
            this.buttonSaveFileNames = new System.Windows.Forms.Button();
            this.buttonGetTagsFromFileName = new System.Windows.Forms.Button();
            this.buttonMoveToTargetFolder = new System.Windows.Forms.Button();
            this.buttonCapitalizeTitles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceFolderBrowser
            // 
            this.sourceFolderBrowser.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // buttonSourceFolder
            // 
            this.buttonSourceFolder.Location = new System.Drawing.Point(57, 23);
            this.buttonSourceFolder.Name = "buttonSourceFolder";
            this.buttonSourceFolder.Size = new System.Drawing.Size(85, 22);
            this.buttonSourceFolder.TabIndex = 1;
            this.buttonSourceFolder.Text = "SourceFolder";
            this.buttonSourceFolder.UseVisualStyleBackColor = true;
            this.buttonSourceFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSourceFoloder
            // 
            this.labelSourceFoloder.AutoSize = true;
            this.labelSourceFoloder.Location = new System.Drawing.Point(148, 28);
            this.labelSourceFoloder.Name = "labelSourceFoloder";
            this.labelSourceFoloder.Size = new System.Drawing.Size(0, 13);
            this.labelSourceFoloder.TabIndex = 2;
            // 
            // buttonTargetFoloder
            // 
            this.buttonTargetFoloder.Location = new System.Drawing.Point(57, 51);
            this.buttonTargetFoloder.Name = "buttonTargetFoloder";
            this.buttonTargetFoloder.Size = new System.Drawing.Size(85, 22);
            this.buttonTargetFoloder.TabIndex = 3;
            this.buttonTargetFoloder.Text = "TargetFolder";
            this.buttonTargetFoloder.UseVisualStyleBackColor = true;
            this.buttonTargetFoloder.Click += new System.EventHandler(this.buttonTargetFoloder_Click);
            // 
            // labelTargetFolder
            // 
            this.labelTargetFolder.AutoSize = true;
            this.labelTargetFolder.Location = new System.Drawing.Point(148, 56);
            this.labelTargetFolder.Name = "labelTargetFolder";
            this.labelTargetFolder.Size = new System.Drawing.Size(0, 13);
            this.labelTargetFolder.TabIndex = 4;
            // 
            // buttonPreviousFolder
            // 
            this.buttonPreviousFolder.Location = new System.Drawing.Point(57, 95);
            this.buttonPreviousFolder.Name = "buttonPreviousFolder";
            this.buttonPreviousFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonPreviousFolder.TabIndex = 5;
            this.buttonPreviousFolder.Text = "<";
            this.buttonPreviousFolder.UseVisualStyleBackColor = true;
            this.buttonPreviousFolder.Click += new System.EventHandler(this.buttonPreviousFolder_Click);
            // 
            // buttonNextFolder
            // 
            this.buttonNextFolder.Location = new System.Drawing.Point(151, 95);
            this.buttonNextFolder.Name = "buttonNextFolder";
            this.buttonNextFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonNextFolder.TabIndex = 6;
            this.buttonNextFolder.Text = ">";
            this.buttonNextFolder.UseVisualStyleBackColor = true;
            this.buttonNextFolder.Click += new System.EventHandler(this.buttonNextFolder_Click);
            // 
            // dataGridFiles
            // 
            this.dataGridFiles.AllowUserToAddRows = false;
            this.dataGridFiles.AllowUserToDeleteRows = false;
            this.dataGridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path,
            this.FileName,
            this.Artist,
            this.Album,
            this.TrackNo,
            this.Title,
            this.Year,
            this.Genre,
            this.Disc});
            this.dataGridFiles.Location = new System.Drawing.Point(57, 161);
            this.dataGridFiles.Name = "dataGridFiles";
            this.dataGridFiles.Size = new System.Drawing.Size(1306, 500);
            this.dataGridFiles.TabIndex = 7;
            this.dataGridFiles.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFiles_CellValueChanged);
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Visible = false;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileName.DataPropertyName = "FileName";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.FileName.DefaultCellStyle = dataGridViewCellStyle1;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 79;
            // 
            // Artist
            // 
            this.Artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Artist.DataPropertyName = "Artist";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Artist.DefaultCellStyle = dataGridViewCellStyle2;
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            this.Artist.Width = 55;
            // 
            // Album
            // 
            this.Album.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Album.DataPropertyName = "Album";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Album.DefaultCellStyle = dataGridViewCellStyle3;
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            this.Album.Width = 61;
            // 
            // TrackNo
            // 
            this.TrackNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TrackNo.DataPropertyName = "TrackNo";
            this.TrackNo.HeaderText = "Track no";
            this.TrackNo.Name = "TrackNo";
            this.TrackNo.Width = 75;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Title";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Title.DefaultCellStyle = dataGridViewCellStyle4;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 52;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Year.DataPropertyName = "Year";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Year.DefaultCellStyle = dataGridViewCellStyle5;
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.Width = 54;
            // 
            // Genre
            // 
            this.Genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Genre.DataPropertyName = "Genre";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Genre.DefaultCellStyle = dataGridViewCellStyle6;
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.Width = 61;
            // 
            // Disc
            // 
            this.Disc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Disc.DataPropertyName = "Disc";
            this.Disc.HeaderText = "Disc";
            this.Disc.Name = "Disc";
            this.Disc.Width = 53;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(57, 735);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 46);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save Tags";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(1202, 27);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(161, 20);
            this.textBoxArtist.TabIndex = 9;
            this.textBoxArtist.TextChanged += new System.EventHandler(this.textBoxArtist_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1166, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Artist";
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(1202, 53);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(161, 20);
            this.textBoxAlbum.TabIndex = 11;
            this.textBoxAlbum.TextChanged += new System.EventHandler(this.textBoxAlbum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1160, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Album";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(1202, 79);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(161, 20);
            this.textBoxYear.TabIndex = 13;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1167, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Year";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(1202, 105);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(161, 20);
            this.textBoxGenre.TabIndex = 15;
            this.textBoxGenre.TextChanged += new System.EventHandler(this.textBoxGenre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1160, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Genre";
            // 
            // buttonGetFileNamesFromTags
            // 
            this.buttonGetFileNamesFromTags.Location = new System.Drawing.Point(155, 683);
            this.buttonGetFileNamesFromTags.Name = "buttonGetFileNamesFromTags";
            this.buttonGetFileNamesFromTags.Size = new System.Drawing.Size(92, 46);
            this.buttonGetFileNamesFromTags.TabIndex = 17;
            this.buttonGetFileNamesFromTags.Text = "Get File Names from Tags";
            this.buttonGetFileNamesFromTags.UseVisualStyleBackColor = true;
            this.buttonGetFileNamesFromTags.Click += new System.EventHandler(this.buttonGetFileNamesFromTags_Click);
            // 
            // labelFolderName
            // 
            this.labelFolderName.AutoSize = true;
            this.labelFolderName.Location = new System.Drawing.Point(54, 136);
            this.labelFolderName.Name = "labelFolderName";
            this.labelFolderName.Size = new System.Drawing.Size(0, 13);
            this.labelFolderName.TabIndex = 18;
            // 
            // buttonSaveFileNames
            // 
            this.buttonSaveFileNames.Location = new System.Drawing.Point(155, 735);
            this.buttonSaveFileNames.Name = "buttonSaveFileNames";
            this.buttonSaveFileNames.Size = new System.Drawing.Size(92, 46);
            this.buttonSaveFileNames.TabIndex = 19;
            this.buttonSaveFileNames.Text = "Save File Names";
            this.buttonSaveFileNames.UseVisualStyleBackColor = true;
            this.buttonSaveFileNames.Click += new System.EventHandler(this.buttonSaveFileNames_Click);
            // 
            // buttonGetTagsFromFileName
            // 
            this.buttonGetTagsFromFileName.Location = new System.Drawing.Point(57, 683);
            this.buttonGetTagsFromFileName.Name = "buttonGetTagsFromFileName";
            this.buttonGetTagsFromFileName.Size = new System.Drawing.Size(92, 46);
            this.buttonGetTagsFromFileName.TabIndex = 20;
            this.buttonGetTagsFromFileName.Text = "Get Tags from File Name";
            this.buttonGetTagsFromFileName.UseVisualStyleBackColor = true;
            this.buttonGetTagsFromFileName.Click += new System.EventHandler(this.buttonGetTagsFromFileName_Click);
            // 
            // buttonMoveToTargetFolder
            // 
            this.buttonMoveToTargetFolder.Location = new System.Drawing.Point(57, 787);
            this.buttonMoveToTargetFolder.Name = "buttonMoveToTargetFolder";
            this.buttonMoveToTargetFolder.Size = new System.Drawing.Size(91, 46);
            this.buttonMoveToTargetFolder.TabIndex = 21;
            this.buttonMoveToTargetFolder.Text = "Move to Target Folder";
            this.buttonMoveToTargetFolder.UseVisualStyleBackColor = true;
            this.buttonMoveToTargetFolder.Click += new System.EventHandler(this.buttonMoveToTargetFolder_Click);
            // 
            // buttonCapitalizeTitles
            // 
            this.buttonCapitalizeTitles.Location = new System.Drawing.Point(310, 684);
            this.buttonCapitalizeTitles.Name = "buttonCapitalizeTitles";
            this.buttonCapitalizeTitles.Size = new System.Drawing.Size(91, 45);
            this.buttonCapitalizeTitles.TabIndex = 22;
            this.buttonCapitalizeTitles.Text = "Capitalize Titles";
            this.buttonCapitalizeTitles.UseVisualStyleBackColor = true;
            this.buttonCapitalizeTitles.Click += new System.EventHandler(this.buttonCapitalizeTitles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 849);
            this.Controls.Add(this.buttonCapitalizeTitles);
            this.Controls.Add(this.buttonMoveToTargetFolder);
            this.Controls.Add(this.buttonGetTagsFromFileName);
            this.Controls.Add(this.buttonSaveFileNames);
            this.Controls.Add(this.labelFolderName);
            this.Controls.Add(this.buttonGetFileNamesFromTags);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAlbum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridFiles);
            this.Controls.Add(this.buttonNextFolder);
            this.Controls.Add(this.buttonPreviousFolder);
            this.Controls.Add(this.labelTargetFolder);
            this.Controls.Add(this.buttonTargetFoloder);
            this.Controls.Add(this.labelSourceFoloder);
            this.Controls.Add(this.buttonSourceFolder);
            this.Name = "Form1";
            this.Text = "FlacFriend";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog sourceFolderBrowser;
        private System.Windows.Forms.Button buttonSourceFolder;
        private System.Windows.Forms.Label labelSourceFoloder;
        private System.Windows.Forms.Button buttonTargetFoloder;
        private System.Windows.Forms.Label labelTargetFolder;
        private System.Windows.Forms.FolderBrowserDialog targetFolderBrowser;
        private System.Windows.Forms.Button buttonPreviousFolder;
        private System.Windows.Forms.Button buttonNextFolder;
        private System.Windows.Forms.DataGridView dataGridFiles;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGetFileNamesFromTags;
        private System.Windows.Forms.Label labelFolderName;
        private System.Windows.Forms.Button buttonSaveFileNames;
        private System.Windows.Forms.Button buttonGetTagsFromFileName;
        private System.Windows.Forms.Button buttonMoveToTargetFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disc;
        private System.Windows.Forms.Button buttonCapitalizeTitles;
    }
}


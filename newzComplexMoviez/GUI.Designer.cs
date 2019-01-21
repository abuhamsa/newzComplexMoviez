namespace newzComplexMoviez
{
    partial class GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtb_moviename = new System.Windows.Forms.TextBox();
            this.btn_searchnc = new System.Windows.Forms.Button();
            this.txb_ncresults = new System.Windows.Forms.TextBox();
            this.btn_searchtmdb = new System.Windows.Forms.Button();
            this.lstb_tmdbresults = new System.Windows.Forms.ListBox();
            this.lst_tmdbresults = new System.Windows.Forms.DataGridView();
            this.imdbIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posterPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popularityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voteAverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternativeTitlesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_send2sab = new System.Windows.Forms.Button();
            this.nzbLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieReleaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.lst_tmdbresults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieReleaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtb_moviename
            // 
            this.txtb_moviename.Location = new System.Drawing.Point(33, 28);
            this.txtb_moviename.Name = "txtb_moviename";
            this.txtb_moviename.Size = new System.Drawing.Size(158, 20);
            this.txtb_moviename.TabIndex = 0;
            // 
            // btn_searchnc
            // 
            this.btn_searchnc.Location = new System.Drawing.Point(33, 212);
            this.btn_searchnc.Name = "btn_searchnc";
            this.btn_searchnc.Size = new System.Drawing.Size(187, 23);
            this.btn_searchnc.TabIndex = 2;
            this.btn_searchnc.Text = "Search NewzComplex";
            this.btn_searchnc.UseVisualStyleBackColor = true;
            this.btn_searchnc.Click += new System.EventHandler(this.btn_searchnc_Click);
            // 
            // txb_ncresults
            // 
            this.txb_ncresults.Location = new System.Drawing.Point(33, 549);
            this.txb_ncresults.Multiline = true;
            this.txb_ncresults.Name = "txb_ncresults";
            this.txb_ncresults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_ncresults.Size = new System.Drawing.Size(1046, 198);
            this.txb_ncresults.TabIndex = 3;
            // 
            // btn_searchtmdb
            // 
            this.btn_searchtmdb.Location = new System.Drawing.Point(197, 26);
            this.btn_searchtmdb.Name = "btn_searchtmdb";
            this.btn_searchtmdb.Size = new System.Drawing.Size(142, 23);
            this.btn_searchtmdb.TabIndex = 4;
            this.btn_searchtmdb.Text = "Search TMDB";
            this.btn_searchtmdb.UseVisualStyleBackColor = true;
            this.btn_searchtmdb.Click += new System.EventHandler(this.btn_searchtmdb_Click);
            // 
            // lstb_tmdbresults
            // 
            this.lstb_tmdbresults.FormattingEnabled = true;
            this.lstb_tmdbresults.Location = new System.Drawing.Point(33, 72);
            this.lstb_tmdbresults.Name = "lstb_tmdbresults";
            this.lstb_tmdbresults.Size = new System.Drawing.Size(75, 108);
            this.lstb_tmdbresults.TabIndex = 5;
            // 
            // lst_tmdbresults
            // 
            this.lst_tmdbresults.AllowUserToDeleteRows = false;
            this.lst_tmdbresults.AutoGenerateColumns = false;
            this.lst_tmdbresults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_tmdbresults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imdbIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.originalTitleDataGridViewTextBoxColumn,
            this.overviewDataGridViewTextBoxColumn,
            this.posterPathDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.runtimeDataGridViewTextBoxColumn,
            this.popularityDataGridViewTextBoxColumn,
            this.voteAverageDataGridViewTextBoxColumn,
            this.alternativeTitlesDataGridViewTextBoxColumn});
            this.lst_tmdbresults.DataSource = this.movieBindingSource;
            this.lst_tmdbresults.Location = new System.Drawing.Point(33, 55);
            this.lst_tmdbresults.Name = "lst_tmdbresults";
            this.lst_tmdbresults.ReadOnly = true;
            this.lst_tmdbresults.Size = new System.Drawing.Size(1046, 150);
            this.lst_tmdbresults.TabIndex = 6;
            // 
            // imdbIdDataGridViewTextBoxColumn
            // 
            this.imdbIdDataGridViewTextBoxColumn.DataPropertyName = "ImdbId";
            this.imdbIdDataGridViewTextBoxColumn.HeaderText = "ImdbId";
            this.imdbIdDataGridViewTextBoxColumn.Name = "imdbIdDataGridViewTextBoxColumn";
            this.imdbIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originalTitleDataGridViewTextBoxColumn
            // 
            this.originalTitleDataGridViewTextBoxColumn.DataPropertyName = "OriginalTitle";
            this.originalTitleDataGridViewTextBoxColumn.HeaderText = "OriginalTitle";
            this.originalTitleDataGridViewTextBoxColumn.Name = "originalTitleDataGridViewTextBoxColumn";
            this.originalTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overviewDataGridViewTextBoxColumn
            // 
            this.overviewDataGridViewTextBoxColumn.DataPropertyName = "Overview";
            this.overviewDataGridViewTextBoxColumn.HeaderText = "Overview";
            this.overviewDataGridViewTextBoxColumn.Name = "overviewDataGridViewTextBoxColumn";
            this.overviewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // posterPathDataGridViewTextBoxColumn
            // 
            this.posterPathDataGridViewTextBoxColumn.DataPropertyName = "PosterPath";
            this.posterPathDataGridViewTextBoxColumn.HeaderText = "PosterPath";
            this.posterPathDataGridViewTextBoxColumn.Name = "posterPathDataGridViewTextBoxColumn";
            this.posterPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // runtimeDataGridViewTextBoxColumn
            // 
            this.runtimeDataGridViewTextBoxColumn.DataPropertyName = "Runtime";
            this.runtimeDataGridViewTextBoxColumn.HeaderText = "Runtime";
            this.runtimeDataGridViewTextBoxColumn.Name = "runtimeDataGridViewTextBoxColumn";
            this.runtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // popularityDataGridViewTextBoxColumn
            // 
            this.popularityDataGridViewTextBoxColumn.DataPropertyName = "Popularity";
            this.popularityDataGridViewTextBoxColumn.HeaderText = "Popularity";
            this.popularityDataGridViewTextBoxColumn.Name = "popularityDataGridViewTextBoxColumn";
            this.popularityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voteAverageDataGridViewTextBoxColumn
            // 
            this.voteAverageDataGridViewTextBoxColumn.DataPropertyName = "VoteAverage";
            this.voteAverageDataGridViewTextBoxColumn.HeaderText = "VoteAverage";
            this.voteAverageDataGridViewTextBoxColumn.Name = "voteAverageDataGridViewTextBoxColumn";
            this.voteAverageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alternativeTitlesDataGridViewTextBoxColumn
            // 
            this.alternativeTitlesDataGridViewTextBoxColumn.DataPropertyName = "AlternativeTitles";
            this.alternativeTitlesDataGridViewTextBoxColumn.HeaderText = "AlternativeTitles";
            this.alternativeTitlesDataGridViewTextBoxColumn.Name = "alternativeTitlesDataGridViewTextBoxColumn";
            this.alternativeTitlesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(TMDbLib.Objects.Movies.Movie);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nzbLinkDataGridViewTextBoxColumn,
            this.releaseNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.detailLinkDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.movieReleaseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1046, 272);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_send2sab
            // 
            this.btn_send2sab.Location = new System.Drawing.Point(33, 520);
            this.btn_send2sab.Name = "btn_send2sab";
            this.btn_send2sab.Size = new System.Drawing.Size(187, 23);
            this.btn_send2sab.TabIndex = 8;
            this.btn_send2sab.Text = "Send to Sabnzb";
            this.btn_send2sab.UseVisualStyleBackColor = true;
            this.btn_send2sab.Click += new System.EventHandler(this.btn_send2sab_Click);
            // 
            // nzbLinkDataGridViewTextBoxColumn
            // 
            this.nzbLinkDataGridViewTextBoxColumn.DataPropertyName = "NzbLink";
            this.nzbLinkDataGridViewTextBoxColumn.HeaderText = "NzbLink";
            this.nzbLinkDataGridViewTextBoxColumn.Name = "nzbLinkDataGridViewTextBoxColumn";
            // 
            // releaseNameDataGridViewTextBoxColumn
            // 
            this.releaseNameDataGridViewTextBoxColumn.DataPropertyName = "ReleaseName";
            this.releaseNameDataGridViewTextBoxColumn.HeaderText = "ReleaseName";
            this.releaseNameDataGridViewTextBoxColumn.Name = "releaseNameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // detailLinkDataGridViewTextBoxColumn
            // 
            this.detailLinkDataGridViewTextBoxColumn.DataPropertyName = "DetailLink";
            this.detailLinkDataGridViewTextBoxColumn.HeaderText = "DetailLink";
            this.detailLinkDataGridViewTextBoxColumn.Name = "detailLinkDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // movieReleaseBindingSource
            // 
            this.movieReleaseBindingSource.DataSource = typeof(newzComplexMoviez.MovieRelease);
            this.movieReleaseBindingSource.Sort = "";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 760);
            this.Controls.Add(this.btn_send2sab);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lst_tmdbresults);
            this.Controls.Add(this.lstb_tmdbresults);
            this.Controls.Add(this.btn_searchtmdb);
            this.Controls.Add(this.txb_ncresults);
            this.Controls.Add(this.btn_searchnc);
            this.Controls.Add(this.txtb_moviename);
            this.Name = "GUI";
            this.Text = "newzComplexMoviez";
            ((System.ComponentModel.ISupportInitialize)(this.lst_tmdbresults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieReleaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_moviename;
        private System.Windows.Forms.Button btn_searchnc;
        private System.Windows.Forms.TextBox txb_ncresults;
        private System.Windows.Forms.Button btn_searchtmdb;
        private System.Windows.Forms.ListBox lstb_tmdbresults;
        private System.Windows.Forms.DataGridView lst_tmdbresults;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perfectDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn multilanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn audiosourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autotypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videosourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videocodecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdbIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posterPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popularityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voteAverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativeTitlesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nzbLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource movieReleaseBindingSource;
        private System.Windows.Forms.Button btn_send2sab;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}


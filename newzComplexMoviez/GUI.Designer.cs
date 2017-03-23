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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdbIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taglineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homepageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backdropPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posterPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.videoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popularityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voteAverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voteCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternativeTitlesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.similarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountStatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lst_tmdbresults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
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
            this.txb_ncresults.Location = new System.Drawing.Point(33, 241);
            this.txb_ncresults.Multiline = true;
            this.txb_ncresults.Name = "txb_ncresults";
            this.txb_ncresults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_ncresults.Size = new System.Drawing.Size(1115, 120);
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
            this.idDataGridViewTextBoxColumn,
            this.imdbIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.originalTitleDataGridViewTextBoxColumn,
            this.originalLanguageDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.taglineDataGridViewTextBoxColumn,
            this.overviewDataGridViewTextBoxColumn,
            this.homepageDataGridViewTextBoxColumn,
            this.backdropPathDataGridViewTextBoxColumn,
            this.posterPathDataGridViewTextBoxColumn,
            this.adultDataGridViewCheckBoxColumn,
            this.videoDataGridViewCheckBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.revenueDataGridViewTextBoxColumn,
            this.budgetDataGridViewTextBoxColumn,
            this.runtimeDataGridViewTextBoxColumn,
            this.popularityDataGridViewTextBoxColumn,
            this.voteAverageDataGridViewTextBoxColumn,
            this.voteCountDataGridViewTextBoxColumn,
            this.alternativeTitlesDataGridViewTextBoxColumn,
            this.releasesDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.imagesDataGridViewTextBoxColumn,
            this.keywordsDataGridViewTextBoxColumn,
            this.videosDataGridViewTextBoxColumn,
            this.translationsDataGridViewTextBoxColumn,
            this.similarDataGridViewTextBoxColumn,
            this.reviewsDataGridViewTextBoxColumn,
            this.listsDataGridViewTextBoxColumn,
            this.accountStatesDataGridViewTextBoxColumn});
            this.lst_tmdbresults.DataSource = this.movieBindingSource;
            this.lst_tmdbresults.Location = new System.Drawing.Point(33, 55);
            this.lst_tmdbresults.Name = "lst_tmdbresults";
            this.lst_tmdbresults.ReadOnly = true;
            this.lst_tmdbresults.Size = new System.Drawing.Size(1115, 150);
            this.lst_tmdbresults.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // originalLanguageDataGridViewTextBoxColumn
            // 
            this.originalLanguageDataGridViewTextBoxColumn.DataPropertyName = "OriginalLanguage";
            this.originalLanguageDataGridViewTextBoxColumn.HeaderText = "OriginalLanguage";
            this.originalLanguageDataGridViewTextBoxColumn.Name = "originalLanguageDataGridViewTextBoxColumn";
            this.originalLanguageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taglineDataGridViewTextBoxColumn
            // 
            this.taglineDataGridViewTextBoxColumn.DataPropertyName = "Tagline";
            this.taglineDataGridViewTextBoxColumn.HeaderText = "Tagline";
            this.taglineDataGridViewTextBoxColumn.Name = "taglineDataGridViewTextBoxColumn";
            this.taglineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overviewDataGridViewTextBoxColumn
            // 
            this.overviewDataGridViewTextBoxColumn.DataPropertyName = "Overview";
            this.overviewDataGridViewTextBoxColumn.HeaderText = "Overview";
            this.overviewDataGridViewTextBoxColumn.Name = "overviewDataGridViewTextBoxColumn";
            this.overviewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homepageDataGridViewTextBoxColumn
            // 
            this.homepageDataGridViewTextBoxColumn.DataPropertyName = "Homepage";
            this.homepageDataGridViewTextBoxColumn.HeaderText = "Homepage";
            this.homepageDataGridViewTextBoxColumn.Name = "homepageDataGridViewTextBoxColumn";
            this.homepageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // backdropPathDataGridViewTextBoxColumn
            // 
            this.backdropPathDataGridViewTextBoxColumn.DataPropertyName = "BackdropPath";
            this.backdropPathDataGridViewTextBoxColumn.HeaderText = "BackdropPath";
            this.backdropPathDataGridViewTextBoxColumn.Name = "backdropPathDataGridViewTextBoxColumn";
            this.backdropPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // posterPathDataGridViewTextBoxColumn
            // 
            this.posterPathDataGridViewTextBoxColumn.DataPropertyName = "PosterPath";
            this.posterPathDataGridViewTextBoxColumn.HeaderText = "PosterPath";
            this.posterPathDataGridViewTextBoxColumn.Name = "posterPathDataGridViewTextBoxColumn";
            this.posterPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adultDataGridViewCheckBoxColumn
            // 
            this.adultDataGridViewCheckBoxColumn.DataPropertyName = "Adult";
            this.adultDataGridViewCheckBoxColumn.HeaderText = "Adult";
            this.adultDataGridViewCheckBoxColumn.Name = "adultDataGridViewCheckBoxColumn";
            this.adultDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // videoDataGridViewCheckBoxColumn
            // 
            this.videoDataGridViewCheckBoxColumn.DataPropertyName = "Video";
            this.videoDataGridViewCheckBoxColumn.HeaderText = "Video";
            this.videoDataGridViewCheckBoxColumn.Name = "videoDataGridViewCheckBoxColumn";
            this.videoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // revenueDataGridViewTextBoxColumn
            // 
            this.revenueDataGridViewTextBoxColumn.DataPropertyName = "Revenue";
            this.revenueDataGridViewTextBoxColumn.HeaderText = "Revenue";
            this.revenueDataGridViewTextBoxColumn.Name = "revenueDataGridViewTextBoxColumn";
            this.revenueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // budgetDataGridViewTextBoxColumn
            // 
            this.budgetDataGridViewTextBoxColumn.DataPropertyName = "Budget";
            this.budgetDataGridViewTextBoxColumn.HeaderText = "Budget";
            this.budgetDataGridViewTextBoxColumn.Name = "budgetDataGridViewTextBoxColumn";
            this.budgetDataGridViewTextBoxColumn.ReadOnly = true;
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
            // voteCountDataGridViewTextBoxColumn
            // 
            this.voteCountDataGridViewTextBoxColumn.DataPropertyName = "VoteCount";
            this.voteCountDataGridViewTextBoxColumn.HeaderText = "VoteCount";
            this.voteCountDataGridViewTextBoxColumn.Name = "voteCountDataGridViewTextBoxColumn";
            this.voteCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alternativeTitlesDataGridViewTextBoxColumn
            // 
            this.alternativeTitlesDataGridViewTextBoxColumn.DataPropertyName = "AlternativeTitles";
            this.alternativeTitlesDataGridViewTextBoxColumn.HeaderText = "AlternativeTitles";
            this.alternativeTitlesDataGridViewTextBoxColumn.Name = "alternativeTitlesDataGridViewTextBoxColumn";
            this.alternativeTitlesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releasesDataGridViewTextBoxColumn
            // 
            this.releasesDataGridViewTextBoxColumn.DataPropertyName = "Releases";
            this.releasesDataGridViewTextBoxColumn.HeaderText = "Releases";
            this.releasesDataGridViewTextBoxColumn.Name = "releasesDataGridViewTextBoxColumn";
            this.releasesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            this.creditsDataGridViewTextBoxColumn.HeaderText = "Credits";
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            this.creditsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imagesDataGridViewTextBoxColumn
            // 
            this.imagesDataGridViewTextBoxColumn.DataPropertyName = "Images";
            this.imagesDataGridViewTextBoxColumn.HeaderText = "Images";
            this.imagesDataGridViewTextBoxColumn.Name = "imagesDataGridViewTextBoxColumn";
            this.imagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keywordsDataGridViewTextBoxColumn
            // 
            this.keywordsDataGridViewTextBoxColumn.DataPropertyName = "Keywords";
            this.keywordsDataGridViewTextBoxColumn.HeaderText = "Keywords";
            this.keywordsDataGridViewTextBoxColumn.Name = "keywordsDataGridViewTextBoxColumn";
            this.keywordsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // videosDataGridViewTextBoxColumn
            // 
            this.videosDataGridViewTextBoxColumn.DataPropertyName = "Videos";
            this.videosDataGridViewTextBoxColumn.HeaderText = "Videos";
            this.videosDataGridViewTextBoxColumn.Name = "videosDataGridViewTextBoxColumn";
            this.videosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // translationsDataGridViewTextBoxColumn
            // 
            this.translationsDataGridViewTextBoxColumn.DataPropertyName = "Translations";
            this.translationsDataGridViewTextBoxColumn.HeaderText = "Translations";
            this.translationsDataGridViewTextBoxColumn.Name = "translationsDataGridViewTextBoxColumn";
            this.translationsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // similarDataGridViewTextBoxColumn
            // 
            this.similarDataGridViewTextBoxColumn.DataPropertyName = "Similar";
            this.similarDataGridViewTextBoxColumn.HeaderText = "Similar";
            this.similarDataGridViewTextBoxColumn.Name = "similarDataGridViewTextBoxColumn";
            this.similarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reviewsDataGridViewTextBoxColumn
            // 
            this.reviewsDataGridViewTextBoxColumn.DataPropertyName = "Reviews";
            this.reviewsDataGridViewTextBoxColumn.HeaderText = "Reviews";
            this.reviewsDataGridViewTextBoxColumn.Name = "reviewsDataGridViewTextBoxColumn";
            this.reviewsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listsDataGridViewTextBoxColumn
            // 
            this.listsDataGridViewTextBoxColumn.DataPropertyName = "Lists";
            this.listsDataGridViewTextBoxColumn.HeaderText = "Lists";
            this.listsDataGridViewTextBoxColumn.Name = "listsDataGridViewTextBoxColumn";
            this.listsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountStatesDataGridViewTextBoxColumn
            // 
            this.accountStatesDataGridViewTextBoxColumn.DataPropertyName = "AccountStates";
            this.accountStatesDataGridViewTextBoxColumn.HeaderText = "AccountStates";
            this.accountStatesDataGridViewTextBoxColumn.Name = "accountStatesDataGridViewTextBoxColumn";
            this.accountStatesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(TMDbLib.Objects.Movies.Movie);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 451);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdbIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalLanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taglineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homepageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backdropPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posterPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adultDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn videoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn popularityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voteAverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voteCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alternativeTitlesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keywordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn similarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountStatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource movieBindingSource;
    }
}


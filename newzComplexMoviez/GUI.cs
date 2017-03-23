
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;

namespace newzComplexMoviez
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void btn_searchtmdb_Click(object sender, EventArgs e)
        {
            Searcher searcher = new Searcher();
            List<Movie> movies = searcher.searchTMDB(txtb_moviename.Text);

            foreach (Movie movie in movies) {  

                // lstb_tmdbresults.Items.Add(movies[i].Title+" ("+datetime.Year+")");
                movieBindingSource.Add(movie);
            }

           

        }

        private void btn_searchnc_Click(object sender, EventArgs e)
        {
            Searcher searcher = new Searcher();
            int selectedrowindex = lst_tmdbresults.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = lst_tmdbresults.Rows[selectedrowindex];
            string imdbid = Convert.ToString(selectedRow.Cells[1].Value);

            List<MovieRelease> movieReleases = searcher.searchNewz(imdbid);

            foreach (MovieRelease movieRelease in movieReleases)
            {
                txb_ncresults.Text += movieRelease.ToString(false);
               Console.WriteLine(movieRelease.ReleaseName);

            }


        }

        

    }
    }


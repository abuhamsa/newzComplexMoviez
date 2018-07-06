
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

        //THIS HAPPENS IF YOU CLICK THE "Search TMBD"-BUTTON
        private void btn_searchtmdb_Click(object sender, EventArgs e)
        {
            //CREATES A NEW SEARCHER
            Searcher searcher = new Searcher();
            //SEARCHES  TMDB WITH STRING FROM SEARCHFIELD
            List<Movie> movies = searcher.searchTMDB(txtb_moviename.Text);

            foreach (Movie movie in movies) {  

                // lstb_tmdbresults.Items.Add(movies[i].Title+" ("+datetime.Year+")");
                //ADDING THE MOVIE IN THE TABLE 
                //TODO: WE NEED A BETTER SELECTION THAN THIS
                movieBindingSource.Add(movie);
            }

           

        }

        //THIS HAPPENS IF YOU CLICK THE "Search NewzComplex"-BUTTON
        private void btn_searchnc_Click(object sender, EventArgs e)
        {
            //CREATES A NEW SEARCHER
            Searcher searcher = new Searcher();
            //GET IMDBID FROM SELECTED TABLEENTRY
            int selectedrowindex = lst_tmdbresults.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = lst_tmdbresults.Rows[selectedrowindex];
            string imdbid = Convert.ToString(selectedRow.Cells[1].Value);

            //SEARCHES THE MOVIE IN NEWZCOMPLEX
            //TODO: THIS IS A DUMMY METHOD ATM
            List<MovieRelease> movieReleases = searcher.searchNewz(imdbid);

            foreach (MovieRelease movieRelease in movieReleases)
            {
               //CREATES OUTPUT IN THE TEXTAREA
               txb_ncresults.Text += movieRelease.ToString(false);

               //SOME DEBUG WRITELINES
               Console.WriteLine(movieRelease.ReleaseName);

            }


        }

        

    }
    }


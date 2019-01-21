
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
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
            movieBindingSource.Clear();
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
            movieReleaseBindingSource.Clear();
            //CREATES A NEW SEARCHER
            Searcher searcher = new Searcher();
            //GET IMDBID FROM SELECTED TABLEENTRY
            int selectedrowindex = lst_tmdbresults.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = lst_tmdbresults.Rows[selectedrowindex];
            string imdbid = Convert.ToString(selectedRow.Cells[0].Value);

            //SEARCHES THE MOVIE IN NEWZCOMPLEX
            //TODO: THIS IS A DUMMY METHOD ATM
            List<MovieRelease> movieReleases = searcher.searchNewz(imdbid);

            DB db = new DB("C:\\Users\\reberja\\Documents\\newzComplexMoviez\\releases.sqlite", "CREATE TABLE MovieRelease (NzbLink VARCHAR(150) NOT NULL,ReleaseName VARCHAR(100) NOT NULL,Category VARCHAR(50) NOT NULL,Description VARCHAR(100) NOT NULL,DetailLink VARCHAR(100) NOT NULL,Score DOUBLE NOT NULL,Imdb DOUBLE NOT NULL,Imdbtitle VARCHAR(50) NOT NULL,Guid VARCHAR(100) NOT NULL, PRIMARY KEY (Guid))");

            foreach (MovieRelease movieRelease in movieReleases)
            {

                movieReleaseBindingSource.Add(movieRelease);
                //CREATES OUTPUT IN THE TEXTAREA
                txb_ncresults.Text += movieRelease.ToString(false,true);

               //SOME DEBUG WRITELINES
               Console.WriteLine(movieRelease.ReleaseName);
                

                db.release2db(movieRelease);

            }


        }

        private void btn_send2sab_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string nzblink = Convert.ToString(selectedRow.Cells[0].Value);

            nzblink = WebUtility.UrlEncode(nzblink);
            string sabnzbd_url = "https://sab.hochzeit-reber.ch/api?output=text&apikey=64a0adb814ff5fb49c7963012a9a53f0";

            HTTPCom hTTPCom = new HTTPCom(sabnzbd_url);

            string method = "&mode=addurl&name=" + nzblink + "&nzbname=&cat=*&script=Default&priority=-100&pp=-1";

            hTTPCom.GET(method);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            Console.WriteLine(Convert.ToString(selectedRow.Cells[0].Value));
        }
    }
    }


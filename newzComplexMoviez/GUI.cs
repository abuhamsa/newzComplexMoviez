using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            TMDbClient client = new TMDbClient("d1ad8f91ddab03ecbf80e5ca265fb453");
            SearchContainer<SearchMovie> results = client.SearchMovie(txtb_moviename.Text);

            

            Console.WriteLine("Got {0} of {1} results", results.Results.Count, results.TotalResults);
            List<Movie> movies = new List<Movie>();
            int i = 0;
            foreach (SearchMovie result in results.Results) {
                movies.Add(client.GetMovie(result.Id,"DE"));
                
                Console.WriteLine(movies[i].Title);
                DateTime datetime = movies[i].ReleaseDate.Value;

                

                lstb_tmdbresults.Items.Add(movies[i].Title+" ("+datetime.Year+")");

                movieBindingSource.Add(movies[i]);
                
                 i++;
            }

           

        }

        private void btn_searchnc_Click(object sender, EventArgs e)
        {

            int selectedrowindex = lst_tmdbresults.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = lst_tmdbresults.Rows[selectedrowindex];
            string imdbid = Convert.ToString(selectedRow.Cells[1].Value);
            imdbid = imdbid.TrimStart('t');
            HTTPCom httpcom = new HTTPCom("http://www.newz-complex.org/www/api?imdbid=");


            
            txb_ncresults.Text = httpcom.GET(imdbid + "&apikey=xxx&t=movie&extended=1");
        }
    }
}

﻿
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
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


            
            txb_ncresults.Text = httpcom.GET(imdbid + "&apikey=51e3a2d1d949c66b54431708b8eec49e&t=movie&extended=1");
            Console.WriteLine(httpcom.url + imdbid + "&apikey=51e3a2d1d949c66b54431708b8eec49e&t=movie&extended=1");

            XDocument feedXML = XDocument.Load(httpcom.url + imdbid + "&apikey=51e3a2d1d949c66b54431708b8eec49e&t=movie&extended=1");

            var feeds = from feed in feedXML.Descendants("item")
                        select new
                        {
                            Title = feed.Element("title").Value,
                            Link = feed.Element("link").Value,
                            Category = feed.Element("category").Value,
                            Description = feed.Element("description").Value

                        };

           
            XmlReader reader = XmlReader.Create(httpcom.url + imdbid + "&apikey=51e3a2d1d949c66b54431708b8eec49e&t=movie&extended=1");
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            foreach (SyndicationItem item in feed.Items)
            {
                String subject = item.Title.Text;
                String summary = item.Summary.Text;
                 
}

            Console.WriteLine(httpcom.url + imdbid + "&apikey=51e3a2d1d949c66b54431708b8eec49e&t=movie&extended=1");

        }
    }
}

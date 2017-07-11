using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;

namespace newzComplexMoviez
{
    class Searcher
    {
        


        public List<Movie> searchTMDB (string searchString)
        {

            TMDbClient client = new TMDbClient("d1ad8f91ddab03ecbf80e5ca265fb453");
            SearchContainer<SearchMovie> results = client.SearchMovie(searchString);

            List<Movie> movies = new List<Movie>();

            foreach (SearchMovie result in results.Results)
            {
                movies.Add(client.GetMovie(result.Id, "DE"));
  
            }

            return movies;
        }


        public List<MovieRelease> searchNewz (string imdbid)
        {
            imdbid = imdbid.TrimStart('t');
            string baseurl = "http://www.newz-complex.org/www/api?imdbid=";
            string url = baseurl + imdbid + "&apikey=xxxe&t=movie&extended=1";


            List<MovieRelease> movieReleases = new List<MovieRelease>();


            var xml = XDocument.Load("api.xml");

            XNamespace ns = "http://www.newznab.com/DTD/2010/feeds/attributes/";
            foreach (var item in xml.Descendants("item"))
            {


                MovieRelease movieRelease = new MovieRelease();
                movieRelease.ReleaseName = item.Element("title").Value;
                movieRelease.DetailLink = item.Element("guid").Value;
                movieRelease.NzbLink = item.Element("link").Value;
                movieRelease.Category = item.Element("category").Value;
                movieRelease.Description = item.Element("description").Value;




                foreach (var attribute in item.Elements(ns + "attr"))
                {

                    ReleaseAttribute releaseAttribute = new ReleaseAttribute(
                        attribute.Attribute("name").Value,
                        attribute.Attribute("value").Value);
                    movieRelease.Attributes.Add(releaseAttribute);

                }
                movieRelease.Score = movieRelease.scoring();
                movieReleases.Add(movieRelease);




            }


            return movieReleases;
        }

        
    }
}

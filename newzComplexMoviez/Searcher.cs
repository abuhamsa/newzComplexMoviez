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
        

        // SEARCH IN TMDB WITH THE TMDBLib
        public List<Movie> searchTMDB (string searchString)
        {
            //APIKEY
            //TODO: REMOVE HARDCODED APIKEY
            TMDbClient client = new TMDbClient("d1ad8f91ddab03ecbf80e5ca265fb453");

            //SEARCHCONTAINER AND SEARCHMOVIE ARE CLASSES FROM TMDBLib
            SearchContainer<SearchMovie> results = client.SearchMovie(searchString);

            //MOVIE IS A CLASS FROM TMDBLib
            List<Movie> movies = new List<Movie>();

            foreach (SearchMovie result in results.Results)
            {
                //GET THE MOVIE IN GERMAN
                movies.Add(client.GetMovie(result.Id, "DE"));
  
            }
           return movies;
        }

        // SEARCH IN NEWZCOMPLEX WITH THE IMDB-ID
        // TODO: ADD LIVE SUPPORT / REMOVE STATIC API.XML
        public List<MovieRelease> searchNewzStatic (string imdbid)
        {
            //REMOVE THE "t" FROM THE IMDB-ID
            imdbid = imdbid.TrimStart('t');

            //TODO: BASEURL SHOULD BE IN CONFIG
            //TODO: BASEURL IS WRONG ATM
            string baseurl = "http://www.newz-complex.org/www/api?imdbid=";

            //SETTING URL TOGETHER
            //TODO APIKEY SHOULD BE IN CONFIG
            string url = baseurl + imdbid + "&apikey=xxxe&t=movie&extended=1";

            //CREATE OWN MOVIERELEASES-LIST
            List<MovieRelease> movieReleases = new List<MovieRelease>();

            //LOAD LOCAL STATIC API.XML
            //TODO: HERE I SHOULD LOAD THE XML FROM THE ACTUAL API
            var xml = XDocument.Load("api.xml");

            //THE NAMESPACE CONTAINS THE SCHEME OF THE XML WHICH HELPS TO SERIALZE IT TO AN MOVIERELEASE-OBJECT
            XNamespace ns = "http://www.newznab.com/DTD/2010/feeds/attributes/";

            //FOR EVERY ITEM IN THE XML CREATE A MOVIERELEASE-OBJECT
            foreach (var item in xml.Descendants("item"))
            {

                //ADDING ALL REAGULAR TAGS TO THE MOVIERELEASE-OBJECT 
                MovieRelease movieRelease = new MovieRelease();
                movieRelease.ReleaseName = item.Element("title").Value;
                movieRelease.DetailLink = item.Element("guid").Value;
                movieRelease.NzbLink = item.Element("link").Value;
                movieRelease.Category = item.Element("category").Value;
                movieRelease.Description = item.Element("description").Value;



                //FOR THE TAG "ATTRIBUTES" WE NEEDED SOMESPECIAL TREATS
                foreach (var attribute in item.Elements(ns + "attr"))
                {

                    ReleaseAttribute releaseAttribute = new ReleaseAttribute(
                        attribute.Attribute("name").Value,
                        attribute.Attribute("value").Value);
                    movieRelease.Attributes.Add(releaseAttribute);

                }

                //FOR SETTING THE SCORE OF A MOVIERELEASE WE NEED A NEW OBJECT (SCORER)
                Scorer scorer = new Scorer();

                //THE LOGIC OF THE CALCULATING IS IN THE SCORER-CLASS
                movieRelease.Scorelist = scorer.CalculateScore(scorer.CreateScroringAttributeCollectors(), movieRelease);
                movieRelease.Score = scorer.GetTotalScore(movieRelease);
                
                //ADD MOVIERELEASE-OBJECT TO LIST
                movieReleases.Add(movieRelease);

            }
            return movieReleases;
        }


        public List<MovieRelease> searchNewz(string imdbid)
        {
            //REMOVE THE "t" FROM THE IMDB-ID
            imdbid = imdbid.TrimStart('t');

            //TODO: BASEURL SHOULD BE IN CONFIG
            //TODO: BASEURL IS WRONG ATM
            string baseurl = "http://www.newz-complex.org/www/api?imdbid=";

            //SETTING URL TOGETHER
            //TODO APIKEY SHOULD BE IN CONFIG
            string url = baseurl + imdbid + "&apikey=xxxxxxxxxxxxxxxxx&t=movie&extended=1";

            //CREATE OWN MOVIERELEASES-LIST
            List<MovieRelease> movieReleases = new List<MovieRelease>();

            //LOAD LOCAL STATIC API.XML
            //TODO: HERE I SHOULD LOAD THE XML FROM THE ACTUAL API
            HTTPCom hTTPCom = new HTTPCom(url);

            string xmlstring = hTTPCom.GET("");
            var xml = XDocument.Parse(xmlstring);

            //THE NAMESPACE CONTAINS THE SCHEME OF THE XML WHICH HELPS TO SERIALZE IT TO AN MOVIERELEASE-OBJECT
            XNamespace ns = "http://www.newznab.com/DTD/2010/feeds/attributes/";

            //FOR EVERY ITEM IN THE XML CREATE A MOVIERELEASE-OBJECT
            foreach (var item in xml.Descendants("item"))
            {

                //ADDING ALL REAGULAR TAGS TO THE MOVIERELEASE-OBJECT 
                MovieRelease movieRelease = new MovieRelease();
                movieRelease.ReleaseName = item.Element("title").Value;
                movieRelease.DetailLink = item.Element("guid").Value;
                movieRelease.NzbLink = item.Element("link").Value;
                movieRelease.Category = item.Element("category").Value;
                movieRelease.Description = item.Element("description").Value;



                //FOR THE TAG "ATTRIBUTES" WE NEEDED SOMESPECIAL TREATS
                foreach (var attribute in item.Elements(ns + "attr"))
                {

                    ReleaseAttribute releaseAttribute = new ReleaseAttribute(
                        attribute.Attribute("name").Value,
                        attribute.Attribute("value").Value);
                    movieRelease.Attributes.Add(releaseAttribute);

                }

                //FOR SETTING THE SCORE OF A MOVIERELEASE WE NEED A NEW OBJECT (SCORER)
                Scorer scorer = new Scorer();

                //THE LOGIC OF THE CALCULATING IS IN THE SCORER-CLASS
                movieRelease.Scorelist = scorer.CalculateScore(scorer.CreateScroringAttributeCollectors(), movieRelease);
                movieRelease.Score = scorer.GetTotalScore(movieRelease);

                //ADD MOVIERELEASE-OBJECT TO LIST
                movieReleases.Add(movieRelease);

            }
            return movieReleases;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newzComplexMoviez
{
    class MovieRelease
    {
        private String releaseName;
        private String detailLink;
        private String nzbLink;
        private String category;
        private String description;
        private List<ReleaseAttribute> attributes = new List<ReleaseAttribute>();
        private int score;
        private List<Score> scorelist;

              

        public MovieRelease()
        {
        }

        //CONSTRUCTOR1
        public MovieRelease(string releaseName, string detailLink, string nzbLink, string category, string description, List<ReleaseAttribute> attributes, int score, List <Score> scorelist)
        {
            this.releaseName = releaseName;
            this.detailLink = detailLink;
            this.nzbLink = nzbLink;
            this.category = category;
            this.description = description;
            this.attributes = attributes;
            this.score = score;
            this.scorelist = scorelist;
        }

        //CONSTRUCTOR2
        public MovieRelease(string releaseName, string detailLink, string nzbLink, string category, string description, List<ReleaseAttribute> attributes, int score)
        {
            this.releaseName = releaseName;
            this.detailLink = detailLink;
            this.nzbLink = nzbLink;
            this.category = category;
            this.description = description;
            this.attributes = attributes;
            this.score = score;
        }

        //GETTER AND SETTER
        public string NzbLink
        {
            get
            {
                return nzbLink;
            }

            set
            {
                nzbLink = value;
            }
        }

        public string ReleaseName
        {
            get
            {
                return releaseName;
            }

            set
            {
                releaseName = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string DetailLink
        {
            get
            {
                return detailLink;
            }

            set
            {
                detailLink = value;
            }
        }

        internal List<ReleaseAttribute> Attributes
        {
            get
            {
                return attributes;
            }

            set
            {
                attributes = value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        internal List<Score> Scorelist { get => scorelist; set => scorelist = value; }



        //OVERWRITTEN TOSTRING 
        public string ToString(Boolean attribute_bl, Boolean scorelist_bl)
        {
            string movieReleaseString;

            movieReleaseString = "Releasename: " + releaseName + "\r\r\n";
            movieReleaseString += "Detail-Link: " + detailLink + "\r\n";
            movieReleaseString += "NZB-Link: " + nzbLink + "\r\n";
            movieReleaseString += "Category: " + category + "\r\n";
            movieReleaseString += "Description: " + description + "\r\n";
            movieReleaseString += "Score: " + score + "\r\n";

            if (scorelist_bl)
            {
                movieReleaseString += "-------------------------SCORING-------------------------\r\n";
                foreach (Score score in this.scorelist)
                {
                    movieReleaseString += score.Scoringtype + ": " + score.Ratingstring + " with "+score.Scoreint + "\r\n";

                }
                movieReleaseString += "-------------------------SCORING-------------------------\r\n";
            }

            if (attribute_bl)
            {
                movieReleaseString += "-------------------------ATTRIBUTES-------------------------\r\n";
                foreach (ReleaseAttribute releaseAttribute in this.Attributes)
                {
                    movieReleaseString += releaseAttribute.AttributeName + ": " + releaseAttribute.AttributeValue + "\r\n";

                }
                movieReleaseString += "-------------------------ATTRIBUTES-------------------------\r\n";
            }
            movieReleaseString += "\r\n";
                return movieReleaseString;
        }



        

    }
}

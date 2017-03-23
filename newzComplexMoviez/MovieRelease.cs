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
        private Boolean perfect;

      

        public MovieRelease()
        {
        }

        public MovieRelease(string releaseName, string detailLink, string nzbLink, string category, string description, List<ReleaseAttribute> attributes, int score, bool perfect)
        {
            this.releaseName = releaseName;
            this.detailLink = detailLink;
            this.nzbLink = nzbLink;
            this.category = category;
            this.description = description;
            this.attributes = attributes;
            this.score = score;
            this.perfect = perfect;
        }

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

        public bool Perfect
        {
            get
            {
                return perfect;
            }

            set
            {
                perfect = value;
            }
        }

        public string ToString(Boolean attribute_bl)
        {
            string movieReleaseString;

            movieReleaseString = "Releasename: " + releaseName + "\r\r\n";
            movieReleaseString += "Detail-Link: " + detailLink + "\r\n";
            movieReleaseString += "NZB-Link: " + nzbLink + "\r\n";
            movieReleaseString += "Category: " + category + "\r\n";
            movieReleaseString += "Description: " + description + "\r\n";
            movieReleaseString += "Score: " + score + "\r\n";


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

        public int scoring()
        {
            List<String> positivestrings = new List<string>();
            List<String> negativstrings = new List<string>();

            positivestrings.Add("DTS");
            positivestrings.Add("BluRay");
            positivestrings.Add("ENCOUNTERS");

            negativstrings.Add("AC3");
            negativstrings.Add("WebHD");
            negativstrings.Add("PsO");
            
            int posscore= 0;
            int negscore = 0;
            int total = 0;
            
            foreach (string positivstring in positivestrings)
            {
                if (this.releaseName.Contains(positivstring))
                {
                    posscore = posscore + 10;
                }
            }

            foreach (string negativstring in negativstrings)
            {
                if (this.releaseName.Contains(negativstring))
                {
                    negscore = negscore + 10;
                }
            }

            total = posscore - negscore;
            Console.WriteLine("Releasename: " + this.releaseName);
            Console.WriteLine("Positiv: "+ posscore);
            Console.WriteLine("Negativ: " + negscore);
            Console.WriteLine("Total: " + total);
            return posscore - negscore;
        }

    }
}

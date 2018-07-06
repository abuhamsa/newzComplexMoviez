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
        private String multi_language;
        private String audio_source;
        private String auto_type;
        private String resolution;
        private String video_source;
        private String video_codec;
        private String group;

      

        public MovieRelease()
        {
        }

        //CONSTRUCTOR1
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

        //CONSTRUCTOR2
        public MovieRelease(string releaseName, string detailLink, string nzbLink, string category, string description, List<ReleaseAttribute> attributes, int score, bool perfect, string multi_language, string audio_source, string auto_type, string resolution, string video_source, string video_codec, string group)
        {
            this.releaseName = releaseName;
            this.detailLink = detailLink;
            this.nzbLink = nzbLink;
            this.category = category;
            this.description = description;
            this.attributes = attributes;
            this.score = score;
            this.perfect = perfect;
            this.multi_language = multi_language;
            this.audio_source = audio_source;
            this.auto_type = auto_type;
            this.resolution = resolution;
            this.video_source = video_source;
            this.video_codec = video_codec;
            this.group = group;
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

        public string Multi_language { get => multi_language; set => multi_language = value; }
        public string Audio_source { get => audio_source; set => audio_source = value; }
        public string Auto_type { get => auto_type; set => auto_type = value; }
        public string Resolution { get => resolution; set => resolution = value; }
        public string Video_source { get => video_source; set => video_source = value; }
        public string Video_codec { get => video_codec; set => video_codec = value; }
        public string Group { get => group; set => group = value; }



        //OVERWRITTEN TOSTRING 
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



        

    }
}

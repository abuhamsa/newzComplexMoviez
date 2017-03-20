using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newzComplexMoviez
{
    class MovieRelease
    {
        private String nzbLink;
        private String releaseName;
        private String category;
        private String description;

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
    }
}

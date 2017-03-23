using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newzComplexMoviez
{
    class ReleaseAttribute
    {
        private String attributeName;
        private String attributeValue;

        public ReleaseAttribute(string attributeName, string attributeValue)
        {
            this.attributeName = attributeName;
            this.attributeValue = attributeValue;
        }

        public ReleaseAttribute()
        {
           
        }

        public string AttributeName
        {
            get
            {
                return attributeName;
            }

            set
            {
                attributeName = value;
            }
        }

        public string AttributeValue
        {
            get
            {
                return attributeValue;
            }

            set
            {
                attributeValue = value;
            }
        }
    }
}

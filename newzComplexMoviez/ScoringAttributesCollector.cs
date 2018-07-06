using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newzComplexMoviez
{
    class ScoringAttributesCollector
    {
        //SCORINGTYPE FOR EXAMPLE = RESOLUTION
        public String scroringType;
        //SCORINGATTRIBUTES FOR EXAMPLE ["1080p",300000]
        public List<ScoringAttribute> scoringAttributes;
        //IS THIS COLLECTOR ALREADY SCORED OR NOT
        public Boolean scored;
        // SCORE IF NO ATTRIBUTE MATCHES
        public int other_nothing;

        //CONSTRUCTOR
        public ScoringAttributesCollector(string scroringType, List<ScoringAttribute> scoringAttributes, int other_nothing)
        {
            this.scroringType = scroringType;
            this.scoringAttributes = scoringAttributes;
            this.scored = false;
            this.other_nothing = other_nothing;
        }
        
    }
}

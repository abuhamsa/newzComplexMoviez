using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newzComplexMoviez
{
    class Score
    {
        private string scoringtype;
        private int scoreint;
        private string ratingstring;

        public Score()
        {
        }

        public Score(string scoringtype, int scoreint, string ratingstring)
        {
            this.scoringtype = scoringtype;
            this.scoreint = scoreint;
            this.ratingstring = ratingstring;
        }

        public string Scoringtype { get => scoringtype; set => scoringtype = value; }
        public int Scoreint { get => scoreint; set => scoreint = value; }
        public string Ratingstring { get => ratingstring; set => ratingstring = value; }
    }
}

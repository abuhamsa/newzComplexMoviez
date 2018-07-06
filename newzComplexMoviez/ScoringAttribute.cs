using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newzComplexMoviez
{
    class ScoringAttribute
    {
        //STRING THAT NEED TO BE FOUND IN THE MOVIERELEASE TITLE
        private String ratingString;
        //SCORE THAT WILL BE ADDED IF THE STRING IS FOUND
        private int ratingScore;

        //GETTER AND SETTER
        public string RatingString { get => ratingString; set => ratingString = value; }
        public int RatingScore { get => ratingScore; set => ratingScore = value; }

        //CONSTRUCTOR
        public ScoringAttribute(string ratingString, int ratingScore)
        {
            this.ratingString = ratingString;
            this.ratingScore = ratingScore;
        }
    }
}

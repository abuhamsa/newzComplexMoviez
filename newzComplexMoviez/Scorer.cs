using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newzComplexMoviez
{
    class Scorer
    {
        //CREATES LIST WITH SCORINGATTRUBUTESCOLLETORS IN IT (SCORING CONFIG)
        //TODO: CREATE THIS FROM A CONFIGFILE SO THAT ITS NO LONGER HARDCODED
        public List<ScoringAttributesCollector> CreateScroringAttributeCollectors()
        {
            List<ScoringAttributesCollector> scoringAttributesCollectors = new List<ScoringAttributesCollector>();

            
            //CREATES COLLECTOR FOR RESOLUTION
            List<ScoringAttribute> scoringAttributesResolution = new List<ScoringAttribute>();
            ScoringAttribute resolution1080p = new ScoringAttribute("1080p", 300000);
            ScoringAttribute resolution720p = new ScoringAttribute("720p", 200000);
            scoringAttributesResolution.Add(resolution1080p);
            scoringAttributesResolution.Add(resolution720p);
            ScoringAttributesCollector scoringAttributesCollectorResolution = new ScoringAttributesCollector("Resolution",scoringAttributesResolution,100000);
            scoringAttributesCollectors.Add(scoringAttributesCollectorResolution);

            //CREATES COLLECTOR FOR VIDEOSOURCE
            List<ScoringAttribute> scoringAttributesVideoSource = new List<ScoringAttribute>();
            ScoringAttribute videosourcebluray = new ScoringAttribute("BluRay", 30000);
            ScoringAttribute videosourcewebhd = new ScoringAttribute("WebHD", 20000);
            scoringAttributesVideoSource.Add(videosourcebluray);
            scoringAttributesVideoSource.Add(videosourcewebhd);
            ScoringAttributesCollector scoringAttributesCollectorVideo = new ScoringAttributesCollector("VideoSource", scoringAttributesVideoSource, 10000);
            scoringAttributesCollectors.Add(scoringAttributesCollectorVideo);

            
            return scoringAttributesCollectors;

        }

        // CALCULATE THE SCORE FOR A MOVIERELEASE WITH SCORINGATTRIBUTES
        public int CalculateScore(List<ScoringAttributesCollector> scoringAttributesCollectors,MovieRelease movieRelease)
        {
            //INITIAL SCORE IS 0
            int score = 0;
            foreach (ScoringAttributesCollector collector in scoringAttributesCollectors)
            {
                foreach (ScoringAttribute attribute in collector.scoringAttributes)
                {
                    {
                        //CHECK IF COLLECTOR IS ALREADY SCORED AND IF THE RATINGSTRING IS IN THE RELEASENAME
                        if (collector.scored==false && movieRelease.ReleaseName.Contains(attribute.RatingString))
                        {
                            collector.scored = true;
                            score += attribute.RatingScore;

                            //SOME DEBUG-WRITELINES
                            Console.WriteLine("Releasename: " + movieRelease.ReleaseName);
                            Console.WriteLine(collector.scroringType+"Score: " + attribute.RatingScore);
                        }
                    }
                }
                // IF NONE OF THE RATINGSTRINGS IN THE COLLECTOR HAVE MATCHES IN RELEASENAME WE HAVE TO SCORE THE "OTHER_NOTHING"-SCORE
                if (collector.scored == false)
                {
                    collector.scored = true;
                    score += collector.other_nothing;

                    //SOME DEBUG-WRITELINES
                    Console.WriteLine("Releasename: " + movieRelease.ReleaseName);
                    Console.WriteLine(collector.scroringType + "Score: " + collector.other_nothing);
                    
                }
            }
            //SOME DEBUG-WRITELINE
            Console.WriteLine("TotalScore: " + score);

            return score;
        }
        
    }
}

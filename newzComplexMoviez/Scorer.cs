using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
            string scroringjson = File.ReadAllText("C:\\Users\\reberja\\Documents\\newzComplexMoviez\\scoring.json");
            //List<ScoringAttributesCollector> scoringAttributesCollectors = new List<ScoringAttributesCollector>();
            List<ScoringAttributesCollector> scoringAttributesCollectors = JsonConvert.DeserializeObject<List<ScoringAttributesCollector>>(scroringjson);

            //CREATES COLLECTOR FOR RESOLUTION
            /*List<ScoringAttribute> scoringAttributesResolution = new List<ScoringAttribute>();
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

            string test = JsonConvert.SerializeObject(scoringAttributesCollectors);
            File.WriteAllText("C:\\Users\\reberja\\Documents\\tuttibot\\test.json", test);*/

            return scoringAttributesCollectors;

        }

        // CALCULATE THE SCORE FOR A MOVIERELEASE WITH SCORINGATTRIBUTES
        public List<Score> CalculateScore(List<ScoringAttributesCollector> scoringAttributesCollectors,MovieRelease movieRelease)
        {
            //INITIAL SCORE IS 0
            List<Score> scorelist = new List<Score>();
            foreach (ScoringAttributesCollector collector in scoringAttributesCollectors)
            {
                Score score = new Score();
                score.Scoringtype = collector.scroringType;
                foreach (ScoringAttribute attribute in collector.scoringAttributes)
                {
                    {
                        //CHECK IF COLLECTOR IS ALREADY SCORED AND IF THE RATINGSTRING IS IN THE RELEASENAME
                        if (collector.scored==false && movieRelease.ReleaseName.Contains(attribute.RatingString))
                        {
                            collector.scored = true;
                            score.Ratingstring = attribute.RatingString;
                            score.Scoreint = attribute.RatingScore;
                            
                        }
                    }
                }
                // IF NONE OF THE RATINGSTRINGS IN THE COLLECTOR HAVE MATCHES IN RELEASENAME WE HAVE TO SCORE THE "OTHER_NOTHING"-SCORE
                if (collector.scored == false)
                {
                    collector.scored = true;
                    score.Ratingstring = "None";
                    score.Scoreint = collector.other_nothing;
                    
                    
                }
                scorelist.Add(score);
            }

            return scorelist;
        }
        

        public int GetTotalScore (MovieRelease movieRelease)
        {
            int scoreint = 0;
            foreach (Score score in movieRelease.Scorelist)
            {
                scoreint += score.Scoreint;
            }

            return scoreint;
        }
    }
}

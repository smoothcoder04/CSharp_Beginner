using System;

namespace FootballMatchScoreBoard
{
    public class FootballMatchScore
    {
        //delegate
        public delegate void NotifyScoreEventHandler(string scorer, int scoreteam1, int scoreteam2);

        //decorate delegate with event keyword
        public event NotifyScoreEventHandler NotifyScore;

        public string Team1 { get; set; }
        public string Team2 { get; set; }

        public int Scoreteam1 { get; private set; }
        public int Scoreteam2 { get; private set; }

        public FootballMatchScore(string team1, string team2)
        {
            Team1 = team1;
            Team2 = team2;
        }

        //method to increase score for team1
        public void IncreaseScoreTeam1()
        {
            Scoreteam1++;
            NotifyScore?.Invoke(Team1, Scoreteam1, Scoreteam2);
        }

        public void IncreaseScoreTeam2()
        {
            Scoreteam2++;
            NotifyScore?.Invoke(Team2, Scoreteam1, Scoreteam2);
        }


    }
}
using System;

namespace Delegate_Advanced
{


    public class FootballMatch
    {
        //define the delegate
        public delegate void NotifyGoalScore(string scoringTeam, int ScoreTeam1, int ScoreTeam2);

        public NotifyGoalScore NotifyScore;

        public string Team1 { get; private set; }
        public string Team2 { get; private set; }
        public int ScoreTeam1 { get; private set; }
        public int ScoreTeam2 { get; private set; }

        public FootballMatch(string team1, string team2)
        {
            Team1 = team1;
            Team2 = team2;
        }

        public void IncreaseScoreTeam1()
        {
            ScoreTeam1++;
            NotifyScore?.Invoke(Team1, ScoreTeam1, ScoreTeam2);
            //Get notified when a team scores
            //Console.WriteLine($"{Team1} scored!! Current score is {ScoreTeam1}:{ScoreTeam2}");
        }
        public void IncreaseScoreTeam2()
        {
            ScoreTeam2++;
            NotifyScore?.Invoke(Team2, ScoreTeam1, ScoreTeam2);
            //Get notified when a team scores
            //Console.WriteLine($"{Team2} scored!! Current score is {ScoreTeam2}:{ScoreTeam1}");
        }
    }
}
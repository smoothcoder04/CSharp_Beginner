using System;

namespace EventDelegate
{
    public class FootballMatchScore
    {
        //use built-in evenhandler delegate
        public event EventHandler<GoalScoredArgs> GoalScored;

        public string Team1 { get; private set; }
        public string Team2 { get; private set; }
        public int Team1Score { get; private set; }
        public int Team2Score { get; private set; }

        public FootballMatchScore(string team1, string team2)
        {
            Team1 = team1;
            Team2 = team2;
        }

        public void IncreaseTeam1Score()
        {
            Team1Score++;
            //event subscriber should have a structure Eventname(object sender, EventArgs args)
            GoalScored?.Invoke(this, new GoalScoredArgs(Team1, Team1Score, Team2Score));
        }
        public void IncreaseTeam2Score()
        {
            Team2Score++;
            GoalScored?.Invoke(this, new GoalScoredArgs(Team2, Team1Score, Team2Score));
        }

    }
}
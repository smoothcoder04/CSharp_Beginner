using System;

namespace FootballMatchScoreBoard
{
    public class CustomEvent
    {
        public delegate void GoalScoreHandler(string ScoringTeam, int Team1Score, int Team2Score);
        private event GoalScoreHandler _goalScored;
        public event GoalScoreHandler GoalScored
        {
            add
            {
                //action when subscriber registers
                _goalScored += value;
                Console.WriteLine($"GoalScored has a new subscriber. Method added: {value.Method.Name}");
            }

            remove
            {
                //action when subscriber deregister
                _goalScored -= value;
                Console.WriteLine($"GoalScored event lost a subscriber.. Method added: {value.Method.Name}");

            }
        }

        public string Team1 { get; private set; }
        public string Team2 { get; private set; }
        public int TeamScore1 { get; private set; }
        public int TeamScore2 { get; private set; }

        public CustomEvent(string team1, string team2)
        {
            Team1 = team1;
            Team2 = team2;
        }

        public void IncreaseScoreTeam1New()
        {
            TeamScore1++;
            _goalScored?.Invoke(Team1, TeamScore1, TeamScore2);
        }

        public void IncreaseScoreTeam2New()
        {
            TeamScore2++;
            _goalScored?.Invoke(Team1, TeamScore1, TeamScore2);
        }


    }

}

using System;

namespace Football
{
    public class FootballRow
    {
        private string _team;
        private int _played;
        private int _wins;
        private int _losses;
        private int _draws;
        private int _goalsFor;
        private int _goalsAgainst;
        private int _pts;

        public FootballRow(string team, int played, int wins, int losses, int draws, int goalsFor, int goalsAgainst,
            int pts)
        {
            _team = team;
            _played = played;
            _wins = wins;
            _losses = losses;
            _draws = draws;
            _goalsFor = goalsFor;
            _goalsAgainst = goalsAgainst;
            _pts = pts;
        }

        public string Team
        {
            get => _team;
            set => _team = value;
        }

        public int GoalsFor
        {
            get => _goalsFor;
            set => _goalsFor = value;
        }

        public int GoalsAgainst
        {
            get => _goalsAgainst;
            set => _goalsAgainst = value;
        }

        public int GoalDifference()
        {
            return Math.Abs(GoalsFor - GoalsAgainst);
        }
    }
}
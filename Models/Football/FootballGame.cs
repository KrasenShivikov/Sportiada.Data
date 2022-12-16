namespace Sportiada.Data.Models.Football
{
    using System;
    using System.Collections.Generic;

    public class FootballGame
    {
        public int Id { get; set; }

        public int Attendance { get; set; }

        public DateTime Date { get; set; }

        public int RoundId { get; set; }

        public FootballRound Round { get; set; }

        public List<FootballGameStatistic> GameStatistics { get; set; } = new List<FootballGameStatistic>();

        public List<FootballGameReferee> Referees { get; set; } = new List<FootballGameReferee>();
    }
}

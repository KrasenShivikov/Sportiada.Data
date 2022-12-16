namespace Sportiada.Data.Models.Football
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class FootballGameStatisticCoach
    {
        public int Id { get; set; }

        public int CoachId { get; set; }

        public FootballCoach Coach { get; set; }

        public int GameStatisticId { get; set; }

        public FootballGameStatistic GameStatistic { get; set; }
    }
}

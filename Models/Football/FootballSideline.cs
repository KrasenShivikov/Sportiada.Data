namespace Sportiada.Data.Models.Football
{
    using System.Collections.Generic;

    public class FootballSideline
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public FootballPlayer Player { get; set; }

        public int ReasonId { get; set; }

        public FootballSidelineReason Reason { get; set; }

        public int GameStatisticId { get; set; }

        public FootballGameStatistic GameStatistic { get; set; }
    }
}

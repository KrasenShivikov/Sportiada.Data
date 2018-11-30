namespace Sportiada.Data.Models.Football
{
    using System;

    public class FootballSideCoach
    {
        public int SideId { get; set; }

        public FootballSide Side { get; set; }

        public int CoachId { get; set; }

        public FootballCoach Coach { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? UntilDate { get; set; }

        public string Description { get; set; }

    }
}

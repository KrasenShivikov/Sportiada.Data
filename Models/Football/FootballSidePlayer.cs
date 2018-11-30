namespace Sportiada.Data.Models.Football
{
    using System;

    public class FootballSidePlayer
    {
        public int SideId { get; set; }

        public FootballSide Side { get; set; }

        public int PlayerId { get; set; }

        public FootballPlayer Player { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? UntilDate { get; set; }

        public int PlayerNumber { get; set; }

        public string PlayerPicture { get; set; }

        public bool OnLoanIn { get; set; }

        public bool OnLoamOut { get; set; }

        public bool FirstTeam { get; set; }

        public bool Under23 { get; set; }

        public bool Under18 { get; set; }

    }
}

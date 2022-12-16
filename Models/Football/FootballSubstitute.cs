namespace Sportiada.Data.Models.Football
{
    public class FootballSubstitute
    {
        public int Id { get; set; }

        public int PlayerInId { get; set; }

        public FootballPlayerIn PlayerIn { get; set; }

        public int PlayerOutId { get; set; }

        public FootballPlayerOut PlayerOut { get; set; }

        public int GameStatisticId { get; set; }

        public FootballGameStatistic GameStatistic { get; set; }

        public int Minute { get; set; }

        public bool firstHalf { get; set; }

    }
}

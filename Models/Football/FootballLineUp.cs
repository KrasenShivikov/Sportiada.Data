namespace Sportiada.Data.Models.Football
{
    public class FootballLineUp
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public FootballPlayer Player { get; set; }

        public int GameStattisticId { get; set; }

        public FootballGameStatistic Gamestatistic { get; set; }
    }
}

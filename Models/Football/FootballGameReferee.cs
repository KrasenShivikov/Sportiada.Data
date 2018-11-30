namespace Sportiada.Data.Models.Football
{
    public class FootballGameReferee
    {
        public int Id { get; set; }

        public int RefereeId { get; set; }

        public FootballReferee Referee { get; set; }

        public int TypeId { get; set; }

        public FootballRefereeType Type { get; set; }

        public int GameId { get; set; }

        public FootballGame Game { get; set; }
    }
}

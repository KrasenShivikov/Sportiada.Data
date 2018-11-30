namespace Sportiada.Data.Models.Football
{
    using System.Collections.Generic;

    public class FootballRefereeType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<FootballGameReferee> GameReferees { get; set; } = new List<FootballGameReferee>();
    }
}

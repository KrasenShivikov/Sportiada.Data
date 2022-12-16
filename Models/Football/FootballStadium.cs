using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sportiada.Data.Models.Football
{
    public class FootballStadium
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public string Opened { get; set; }

        public string Architect { get; set; }

        public string Capacity { get; set; }

        public string Surface { get; set; }

        public string PrevousNames { get; set; }

        public string Facts { get; set; }

        public int TeamId { get; set; }

        public FootballTeam Team { get; set; }
    }
}

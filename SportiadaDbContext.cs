namespace Sportiada.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Models.AlpineSki;
    using Models.Football;

    public class SportiadaDbContext : IdentityDbContext<User>
    {
        public SportiadaDbContext(DbContextOptions<SportiadaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Skier> Skiers { get; set; }
        public DbSet<ResultAlpineSki> ResultsAlpineSki { get; set; }
        public DbSet<IntermediateAlpineSki> IntermediatesAlpineSki { get; set; }
        public DbSet<CompetitionAlpineSki> CompetitionsAlpineSki { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<PlaceAlpineSki> PlacesAlpineSki { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<AlpineSkiDisciplines> AlpineSkiDisciplines { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<CompetitionType> CompetitionTypes { get; set; }
        public DbSet<FootballTeam> FootballTeams { get; set; }
        public DbSet<FootballSide> FootballSides { get; set; }
        public DbSet<FootballPlayer> FootballPlayers { get; set; }
        public DbSet<FootballSidePlayer> FootballSidePlayers { get; set; }
        public DbSet<FootballTournament> FootballTournamnets { get; set; }
        public DbSet<FootballCompetition> FootballCompetitions { get; set; }
        public DbSet<FootballRound> FootballRounds { get; set; }
        public DbSet<FootballCoach> FootballCoaches { get; set; }
        public DbSet<FootballSideCoach> FootballSideCoach{ get; set; }
        public DbSet<FootballGame> FootballGames { get; set; }
        public DbSet<FootballLineUp> FootballLineUps { get; set; }
        public DbSet<FootballPlayerIn> FootballPlayerIns { get; set; }
        public DbSet<FootballPlayerOut> FootballPlayerOuts { get; set; }
        public DbSet<FootballSubstitute> FootballSubstitutes { get; set; }
        public DbSet<FootballGoalType> FootballGoalTypes { get; set; }
        public DbSet<FootballGoal> FootballGoals { get; set; }
        public DbSet<FootballCard> FootballCards { get; set; }
        public DbSet<FootballCardType> FootballCardTypes { get; set; }
        public DbSet<FootballGameStatistic> FootballGameStatistics { get; set; }
        public DbSet<FootballGoalAssistance> FootballGoalAssistances { get; set; }
        public DbSet<FootballSideline> FootballSidelines { get; set; }
        public DbSet<FootballSidelineReason> FootballSidelineReasons { get; set; }
        public DbSet<FootballReferee> FootballReferees { get; set; }
        public DbSet<FootballGameReferee> FootballGameReferees { get; set; }
        public DbSet<FootballGameStatisticType> FootballGameStatisticTypes { get; set; }
        public DbSet<FootballPlayerType> FootballPlayerTypes { get; set; }
        public DbSet<FootballReserve> FootballReserves { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Country>()
                .HasMany(c => c.Cities)
                .WithOne(ci => ci.Country)
                .HasForeignKey(ci => ci.CountryId);

            builder.Entity<Country>()
                .HasMany(c => c.FootballPlayers)
                .WithOne(pc => pc.Country)
                .HasForeignKey(pc => pc.CountryId);

            builder.Entity<Skier>()
                .HasOne(s => s.Country)
                .WithMany(c => c.Skiers)
                .HasForeignKey(s => s.CountryId);

            builder.Entity<Skier>()
                .HasMany(s => s.ResultsAlpineSki)
                .WithOne(r => r.Skier)
                .HasForeignKey(r => r.SkierId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ResultAlpineSki>()
                .HasMany(r => r.IntermediatesAlpineSki)
                .WithOne(i => i.ResultAlpineSki)
                .HasForeignKey(i => i.ResultAlpineSkiId);

            builder.Entity<CompetitionAlpineSki>()
                .HasMany(c => c.Results)
                .WithOne(r => r.CompetitionsAlpineSki)
                .HasForeignKey(r => r.CompetitionAlpineSkiId);

            builder.Entity<CompetitionAlpineSki>()
                .HasOne(c => c.Discipline)
                .WithMany(d => d.Competitions)
                .HasForeignKey(c => c.DisciplineAlpineSkiId);

            builder.Entity<CompetitionAlpineSki>()
                .HasOne(c => c.Tournament)
                .WithMany(t => t.Competitions)
                .HasForeignKey(c => c.TournamentId);

            builder.Entity<CompetitionAlpineSki>()
                .HasOne(c => c.Season)
                .WithMany(s => s.Competitions)
                .HasForeignKey(c => c.SeasonId);

            builder.Entity<CompetitionAlpineSki>()
                .HasOne(c => c.CompetitionType)
                .WithMany(t => t.Competitions)
                .HasForeignKey(c => c.CompetitionTypeId);

            builder.Entity<PlaceAlpineSki>()
                .HasOne(p => p.Country)
                .WithMany(c => c.Places)
                .HasForeignKey(c => c.CountryId);

            builder.Entity<PlaceAlpineSki>()
                .HasMany(p => p.Competitions)
                .WithOne(c => c.PlaceAlpineSki)
                .HasForeignKey(p => p.PlaceAlpineSkiId);

            builder.Entity<FootballSidePlayer>()
                .HasKey(ps => new { ps.SideId, ps.PlayerId });

            builder.Entity<FootballSideCoach>()
                .HasKey(cs => new { cs.CoachId, cs.SideId });

            builder.Entity<FootballPlayerCountry>()
                .HasKey(pc => new { pc.PlayerId, pc.CountryId });

            builder.Entity<FootballTeam>()
                .HasOne(t => t.City)
                .WithMany(c => c.FootballTeams)
                .HasForeignKey(t => t.CityId);

            builder.Entity<FootballTeam>()
                .HasMany(t => t.Stadiums)
                .WithOne(s => s.Team)
                .HasForeignKey(s => s.TeamId);

            builder.Entity<FootballTeam>()
                .HasMany(t => t.Sides)
                .WithOne(s => s.Team)
                .HasForeignKey(s => s.TeamId);

            builder.Entity<FootballSide>()
                .HasOne(fs => fs.Season)
                .WithMany(s => s.FootballSides)
                .HasForeignKey(fs => fs.SeasonId);

            builder.Entity<FootballSide>()
                .HasMany(fs => fs.GameStatistics)
                .WithOne(gs => gs.Side)
                .HasForeignKey(gs => gs.SideId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<FootballSide>()
                .HasMany(s => s.Players)
                .WithOne(ps => ps.Side)
                .HasForeignKey(ps => ps.SideId);

            builder.Entity<FootballSide>()
                .HasMany(s => s.Coaches)
                .WithOne(cs => cs.Side)
                .HasForeignKey(cs => cs.SideId);

            builder.Entity<FootballSide>()
                .HasMany(s => s.GameStatistics)
                .WithOne(gs => gs.Side)
                .HasForeignKey(gs => gs.SideId);

            builder.Entity<FootballPlayer>()
                .HasMany(p => p.Countries)
                .WithOne(pc => pc.Player)
                .HasForeignKey(pc => pc.PlayerId);

            builder.Entity<FootballPlayer>()
                .HasMany(p => p.Sides)
                .WithOne(ps => ps.Player)
                .HasForeignKey(ps => ps.PlayerId);

            builder.Entity<FootballPlayer>()
                .HasMany(p => p.LineUps)
                .WithOne(l => l.Player)
                .HasForeignKey(l => l.PlayerId);

            builder.Entity<FootballPlayer>()
                .HasMany(p => p.PlayerIns)
                .WithOne(pi => pi.Player)
                .HasForeignKey(pi => pi.PlayerId);

            builder.Entity<FootballPlayer>()
                .HasMany(p => p.PlayerOuts)
                .WithOne(po => po.Player)
                .HasForeignKey(po => po.PlayerId);

            builder.Entity<FootballPlayer>()
                .HasMany(p => p.Goals)
                .WithOne(g => g.Player)
                .HasForeignKey(g => g.PlayerId);

            builder.Entity<FootballPlayer>()
                .HasMany(p => p.Cards)
                .WithOne(c => c.Player)
                .HasForeignKey(c => c.PlayerId);

            builder.Entity<FootballPlayer>()
                .HasMany(p => p.Sidelines)
                .WithOne(s => s.Player)
                .HasForeignKey(s => s.PlayerId);

            builder.Entity<FootballPlayer>()
                .HasOne(p => p.Type)
                .WithMany(t => t.Players)
                .HasForeignKey(p => p.TypeId);

            builder.Entity<FootballTournament>()
                .HasMany(t => t.Competitions)
                .WithOne(c => c.Tournament)
                .HasForeignKey(c => c.TournamentId);

            builder.Entity<FootballTournament>()
                .HasOne(t => t.Country)
                .WithMany(c => c.FootballTournaments)
                .HasForeignKey(t => t.CountryId);

            builder.Entity<FootballCompetition>()
                .HasOne(c => c.Season)
                .WithMany(s => s.FootballCompetitions)
                .HasForeignKey(c => c.SeasonId);

            builder.Entity<FootballCompetition>()
                .HasOne(c => c.Type)
                .WithMany(t => t.FootballCompetitions)
                .HasForeignKey(c => c.TypeId);

            builder.Entity<FootballCompetition>()
                .HasMany(c => c.Rounds)
                .WithOne(r => r.Competition)
                .HasForeignKey(r => r.CompetitionId);

            builder.Entity<FootballRound>()
                .HasMany(r => r.Games)
                .WithOne(g => g.Round)
                .HasForeignKey(g => g.RoundId);

            builder.Entity<FootballGame>()
                .HasMany(g => g.GameStatistics)
                .WithOne(gs => gs.Game)
                .HasForeignKey(gs => gs.GameId);

            builder.Entity<FootballGame>()
                .HasMany(g => g.Referees)
                .WithOne(r => r.Game)
                .HasForeignKey(r => r.GameId);

            builder.Entity<FootballGameStatistic>()
                .HasOne(gs => gs.Type)
                .WithMany(t => t.GameStatistics)
                .HasForeignKey(gs => gs.TypeId);

            builder.Entity<FootballGameStatistic>()
                .HasMany(gs => gs.LineUps)
                .WithOne(l => l.Gamestatistic)
                .HasForeignKey(l => l.GameStattisticId);

            builder.Entity<FootballGameStatistic>()
                .HasMany(gs => gs.Sidelines)
                .WithOne(s => s.GameStatistic)
                .HasForeignKey(s => s.GameStatisticId);

            builder.Entity<FootballGameStatistic>()
                .HasMany(gs => gs.Substitutes)
                .WithOne(s => s.GameStatistic)
                .HasForeignKey(s => s.GameStatisticId);

            builder.Entity<FootballGameStatistic>()
                .HasMany(gs => gs.Cards)
                .WithOne(c => c.GameStatistic)
                .HasForeignKey(c => c.GameStatisticId);

            builder.Entity<FootballGameStatistic>()
                .HasMany(gs => gs.Goals)
                .WithOne(g => g.GameStatistic)
                .HasForeignKey(g => g.GameStatisticId);

            builder.Entity<FootballSideline>()
                .HasOne(s => s.Reason)
                .WithMany(r => r.Sidelines)
                .HasForeignKey(s => s.ReasonId);

            builder.Entity<FootballCoach>()
                .HasOne(c => c.Country)
                .WithMany(co => co.FootballCoaches)
                .HasForeignKey(c => c.CountryId);

            builder.Entity<FootballCoach>()
                .HasMany(c => c.Sides)
                .WithOne(cs => cs.Coach)
                .HasForeignKey(cs => cs.CoachId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<FootballReferee>()
                .HasOne(r => r.Country)
                .WithMany(c => c.FootballReferees)
                .HasForeignKey(r => r.CountryId);

            builder.Entity<FootballGameReferee>()
                .HasOne(gr => gr.Referee)
                .WithMany(r => r.GameReferees)
                .HasForeignKey(gr => gr.RefereeId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<FootballGameReferee>()
                .HasOne(gr => gr.Type)
                .WithMany(t => t.GameReferees)
                .HasForeignKey(gr => gr.TypeId);

            builder.Entity<FootballGameReferee>()
                .HasOne(gr => gr.Game)
                .WithMany(g => g.Referees)
                .HasForeignKey(gr => gr.GameId);

            builder.Entity<FootballGoal>()
                .HasOne(g => g.Type)
                .WithMany(t => t.Goals)
                .HasForeignKey(g => g.TypeId);

            builder.Entity<FootballGoal>()
                .HasOne(g => g.Player)
                .WithMany(p => p.Goals)
                .HasForeignKey(g => g.PlayerId);

            builder.Entity<FootballGoal>()
                .HasOne(g => g.GameStatistic)
                .WithMany(gs => gs.Goals)
                .HasForeignKey(g => g.GameStatisticId);

            builder.Entity<FootballGoal>()
                .HasOne(g => g.Assistance)
                .WithOne(a => a.Goal)
                .HasForeignKey<FootballGoalAssistance>(a => a.GoalId);

            builder.Entity<FootballGoalAssistance>()
                .HasOne(ga => ga.Player)
                .WithMany(p => p.GoalAssistances)
                .HasForeignKey(ga => ga.PlayerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<FootballSubstitute>()
                .HasOne(s => s.PlayerIn)
                .WithOne(p => p.Substitute)
                .HasForeignKey<FootballPlayerIn>(p => p.SubstituteId);

            builder.Entity<FootballSubstitute>()
                .HasOne(s => s.PlayerOut)
                .WithOne(p => p.Substitute)
                .HasForeignKey<FootballPlayerOut>(p => p.SubstituteId);

            builder.Entity<FootballReserve>()
                .HasOne(r => r.Player)
                .WithMany(p => p.Reserves)
                .HasForeignKey(r => r.PlayerId);

            builder.Entity<FootballReserve>()
                .HasOne(r => r.Gamestatistic)
                .WithMany(gs => gs.Reserves)
                .HasForeignKey(r => r.GameStattisticId);
        }
    }
}

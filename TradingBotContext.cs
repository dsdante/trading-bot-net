using Microsoft.EntityFrameworkCore;

namespace TradingBot
{
    public class TradingBotContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql($"host=/var/run/postgresql;username={Environment.UserName};database=test_db")
                             .UseSnakeCaseNamingConvention();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetType>().HasData(AssetType.Bond,
                                                     AssetType.Currency,
                                                     AssetType.Etf,
                                                     AssetType.Future,
                                                     AssetType.Option,
                                                     AssetType.Share);
        }

        // "EF Core 7.0 and above suppress this warning, since EF automatically initializes these properties via reflection."
        // https://learn.microsoft.com/en-us/ef/core/miscellaneous/nullable-reference-types#dbcontext-and-dbset
        public DbSet<Instrument> Instruments { get; set; } = null!;
        public DbSet<Candle> Candles { get; set; } = null!;
    }
}
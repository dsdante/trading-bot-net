using System.ComponentModel.DataAnnotations.Schema;

namespace TradingBot
{
    [Table("instrument")]
    public class Instrument
    {
        public int Id { get; set; }
        public Guid Uid { get; set; }
        public required string Figi { get; set; }
        public required string Name { get; set; }
        public required AssetType AssetType { get; set; }
        public int Log { get; set; }
        [Column("for_qual_investor_flag")] public bool ForQualInvestor { get; set; }
        [Column("api_trade_available_flag")] public bool ApiTradeAvailable { get; set; }
        public DateTime First1MinCandleDate { get; set; }
        public DateTime First1DayCandleDate { get; set; }

        public required ICollection<Candle> Candles { get; set; }

        public override string ToString() => Name;
    }
}
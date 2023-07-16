using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TradingBot
{
    [Table("candle")]
    [PrimaryKey(nameof(InstrumentId), nameof(Timestamp))]
    public class Candle
    {
        public int InstrumentId { get; set; }
        public required Instrument Instrument { get; set; }
        public DateTime Timestamp { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public int Volume { get; set; }
    }
}
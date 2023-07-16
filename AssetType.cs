using System.ComponentModel.DataAnnotations.Schema;

namespace TradingBot
{
    [Table("asset_type")]
    public class AssetType : IEquatable<AssetType>
    {
        public static AssetType Bond { get; } = new() { Id = 1, Name = "bond" };
        public static AssetType Currency { get; } = new() { Id = 2, Name = "currency" };
        public static AssetType Etf { get; } = new() { Id = 3, Name = "etf" };
        public static AssetType Future { get; } = new() { Id = 4, Name = "future" };
        public static AssetType Option { get; } = new() { Id = 5, Name = "option" };
        public static AssetType Share { get; } = new() { Id = 6, Name = "share" };

        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Instrument> Instruments { get; set; } = null!;

        public bool Equals(AssetType? other) => Id == other?.Id;
        public override string ToString() => Name;
    }
}
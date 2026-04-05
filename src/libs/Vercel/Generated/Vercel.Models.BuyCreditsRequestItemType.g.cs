
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of item to purchase.
    /// </summary>
    public enum BuyCreditsRequestItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Credits,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsRequestItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsRequestItemType value)
        {
            return value switch
            {
                BuyCreditsRequestItemType.Credits => "credits",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsRequestItemType? ToEnum(string value)
        {
            return value switch
            {
                "credits" => BuyCreditsRequestItemType.Credits,
                _ => null,
            };
        }
    }
}
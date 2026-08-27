
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum MarketplaceFlagTypeName
    {
        /// <summary>
        ///
        /// </summary>
        MarketplaceFlag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MarketplaceFlagTypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarketplaceFlagTypeName value)
        {
            return value switch
            {
                MarketplaceFlagTypeName.MarketplaceFlag => "marketplaceFlag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarketplaceFlagTypeName? ToEnum(string value)
        {
            return value switch
            {
                "marketplaceFlag" => MarketplaceFlagTypeName.MarketplaceFlag,
                _ => null,
            };
        }
    }
}
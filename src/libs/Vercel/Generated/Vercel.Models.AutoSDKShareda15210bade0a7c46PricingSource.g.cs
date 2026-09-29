
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The source used as the authoritative price for this intent.
    /// </summary>
    public enum AutoSDKShareda15210bade0a7c46PricingSource
    {
        /// <summary>
        ///
        /// </summary>
        Copper,
        /// <summary>
        ///
        /// </summary>
        Orb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda15210bade0a7c46PricingSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda15210bade0a7c46PricingSource value)
        {
            return value switch
            {
                AutoSDKShareda15210bade0a7c46PricingSource.Copper => "copper",
                AutoSDKShareda15210bade0a7c46PricingSource.Orb => "orb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda15210bade0a7c46PricingSource? ToEnum(string value)
        {
            return value switch
            {
                "copper" => AutoSDKShareda15210bade0a7c46PricingSource.Copper,
                "orb" => AutoSDKShareda15210bade0a7c46PricingSource.Orb,
                _ => null,
            };
        }
    }
}
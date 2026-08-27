
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum MarketplaceFlagCategory
    {
        /// <summary>
        ///
        /// </summary>
        Experiment,
        /// <summary>
        ///
        /// </summary>
        Flag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MarketplaceFlagCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarketplaceFlagCategory value)
        {
            return value switch
            {
                MarketplaceFlagCategory.Experiment => "experiment",
                MarketplaceFlagCategory.Flag => "flag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarketplaceFlagCategory? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => MarketplaceFlagCategory.Experiment,
                "flag" => MarketplaceFlagCategory.Flag,
                _ => null,
            };
        }
    }
}
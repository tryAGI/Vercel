
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum MarketplaceFlagState
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MarketplaceFlagStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarketplaceFlagState value)
        {
            return value switch
            {
                MarketplaceFlagState.Active => "active",
                MarketplaceFlagState.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarketplaceFlagState? ToEnum(string value)
        {
            return value switch
            {
                "active" => MarketplaceFlagState.Active,
                "archived" => MarketplaceFlagState.Archived,
                _ => null,
            };
        }
    }
}
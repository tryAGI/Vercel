
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum BoughtTooRecentlyCode
    {
        /// <summary>
        ///
        /// </summary>
        BoughtTooRecently,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BoughtTooRecentlyCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BoughtTooRecentlyCode value)
        {
            return value switch
            {
                BoughtTooRecentlyCode.BoughtTooRecently => "bought_too_recently",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BoughtTooRecentlyCode? ToEnum(string value)
        {
            return value switch
            {
                "bought_too_recently" => BoughtTooRecentlyCode.BoughtTooRecently,
                _ => null,
            };
        }
    }
}
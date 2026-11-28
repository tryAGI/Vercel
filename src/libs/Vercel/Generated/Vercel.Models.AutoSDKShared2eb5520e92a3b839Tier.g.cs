
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2eb5520e92a3b839Tier
    {
        /// <summary>
        ///
        /// </summary>
        Critical,
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2eb5520e92a3b839TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2eb5520e92a3b839Tier value)
        {
            return value switch
            {
                AutoSDKShared2eb5520e92a3b839Tier.Critical => "critical",
                AutoSDKShared2eb5520e92a3b839Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2eb5520e92a3b839Tier? ToEnum(string value)
        {
            return value switch
            {
                "critical" => AutoSDKShared2eb5520e92a3b839Tier.Critical,
                "priority" => AutoSDKShared2eb5520e92a3b839Tier.Priority,
                _ => null,
            };
        }
    }
}
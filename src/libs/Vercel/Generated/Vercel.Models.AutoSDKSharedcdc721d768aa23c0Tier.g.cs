
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcdc721d768aa23c0Tier
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
    public static class AutoSDKSharedcdc721d768aa23c0TierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcdc721d768aa23c0Tier value)
        {
            return value switch
            {
                AutoSDKSharedcdc721d768aa23c0Tier.Critical => "critical",
                AutoSDKSharedcdc721d768aa23c0Tier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcdc721d768aa23c0Tier? ToEnum(string value)
        {
            return value switch
            {
                "critical" => AutoSDKSharedcdc721d768aa23c0Tier.Critical,
                "priority" => AutoSDKSharedcdc721d768aa23c0Tier.Priority,
                _ => null,
            };
        }
    }
}
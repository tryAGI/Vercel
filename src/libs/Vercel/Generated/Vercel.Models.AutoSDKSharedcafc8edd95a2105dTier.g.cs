
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcafc8edd95a2105dTier
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
    public static class AutoSDKSharedcafc8edd95a2105dTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcafc8edd95a2105dTier value)
        {
            return value switch
            {
                AutoSDKSharedcafc8edd95a2105dTier.Critical => "critical",
                AutoSDKSharedcafc8edd95a2105dTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcafc8edd95a2105dTier? ToEnum(string value)
        {
            return value switch
            {
                "critical" => AutoSDKSharedcafc8edd95a2105dTier.Critical,
                "priority" => AutoSDKSharedcafc8edd95a2105dTier.Priority,
                _ => null,
            };
        }
    }
}
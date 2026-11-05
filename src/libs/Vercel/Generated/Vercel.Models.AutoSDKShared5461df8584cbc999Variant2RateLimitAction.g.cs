
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5461df8584cbc999Variant2RateLimitAction
    {
        /// <summary>
        ///
        /// </summary>
        Challenge,
        /// <summary>
        ///
        /// </summary>
        Deny,
        /// <summary>
        ///
        /// </summary>
        Log,
        /// <summary>
        ///
        /// </summary>
        RateLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared5461df8584cbc999Variant2RateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5461df8584cbc999Variant2RateLimitAction value)
        {
            return value switch
            {
                AutoSDKShared5461df8584cbc999Variant2RateLimitAction.Challenge => "challenge",
                AutoSDKShared5461df8584cbc999Variant2RateLimitAction.Deny => "deny",
                AutoSDKShared5461df8584cbc999Variant2RateLimitAction.Log => "log",
                AutoSDKShared5461df8584cbc999Variant2RateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5461df8584cbc999Variant2RateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared5461df8584cbc999Variant2RateLimitAction.Challenge,
                "deny" => AutoSDKShared5461df8584cbc999Variant2RateLimitAction.Deny,
                "log" => AutoSDKShared5461df8584cbc999Variant2RateLimitAction.Log,
                "rate_limit" => AutoSDKShared5461df8584cbc999Variant2RateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}
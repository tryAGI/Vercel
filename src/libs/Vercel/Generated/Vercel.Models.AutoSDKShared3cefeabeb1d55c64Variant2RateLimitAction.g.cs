
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAction
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
    public static class AutoSDKShared3cefeabeb1d55c64Variant2RateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAction value)
        {
            return value switch
            {
                AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAction.Challenge => "challenge",
                AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAction.Deny => "deny",
                AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAction.Log => "log",
                AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAction.Challenge,
                "deny" => AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAction.Deny,
                "log" => AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAction.Log,
                "rate_limit" => AutoSDKShared3cefeabeb1d55c64Variant2RateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}
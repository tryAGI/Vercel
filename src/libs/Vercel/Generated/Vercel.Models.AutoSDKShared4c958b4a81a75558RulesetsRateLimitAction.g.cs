
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4c958b4a81a75558RulesetsRateLimitAction
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
    public static class AutoSDKShared4c958b4a81a75558RulesetsRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4c958b4a81a75558RulesetsRateLimitAction value)
        {
            return value switch
            {
                AutoSDKShared4c958b4a81a75558RulesetsRateLimitAction.Challenge => "challenge",
                AutoSDKShared4c958b4a81a75558RulesetsRateLimitAction.Deny => "deny",
                AutoSDKShared4c958b4a81a75558RulesetsRateLimitAction.Log => "log",
                AutoSDKShared4c958b4a81a75558RulesetsRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4c958b4a81a75558RulesetsRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared4c958b4a81a75558RulesetsRateLimitAction.Challenge,
                "deny" => AutoSDKShared4c958b4a81a75558RulesetsRateLimitAction.Deny,
                "log" => AutoSDKShared4c958b4a81a75558RulesetsRateLimitAction.Log,
                "rate_limit" => AutoSDKShared4c958b4a81a75558RulesetsRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAction
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
    public static class AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAction.Challenge => "challenge",
                AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAction.Deny => "deny",
                AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAction.Log => "log",
                AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAction.Challenge,
                "deny" => AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAction.Deny,
                "log" => AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAction.Log,
                "rate_limit" => AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}
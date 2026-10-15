
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAction
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
    public static class AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAction value)
        {
            return value switch
            {
                AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAction.Challenge => "challenge",
                AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAction.Deny => "deny",
                AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAction.Log => "log",
                AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAction.Challenge,
                "deny" => AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAction.Deny,
                "log" => AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAction.Log,
                "rate_limit" => AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAction.RateLimit,
                _ => null,
            };
        }
    }
}
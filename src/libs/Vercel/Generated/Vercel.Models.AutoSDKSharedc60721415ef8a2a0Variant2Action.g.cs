
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc60721415ef8a2a0Variant2Action
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Bypass,
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
        /// <summary>
        ///
        /// </summary>
        Redirect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc60721415ef8a2a0Variant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc60721415ef8a2a0Variant2Action value)
        {
            return value switch
            {
                AutoSDKSharedc60721415ef8a2a0Variant2Action.Allow => "allow",
                AutoSDKSharedc60721415ef8a2a0Variant2Action.Bypass => "bypass",
                AutoSDKSharedc60721415ef8a2a0Variant2Action.Challenge => "challenge",
                AutoSDKSharedc60721415ef8a2a0Variant2Action.Deny => "deny",
                AutoSDKSharedc60721415ef8a2a0Variant2Action.Log => "log",
                AutoSDKSharedc60721415ef8a2a0Variant2Action.RateLimit => "rate_limit",
                AutoSDKSharedc60721415ef8a2a0Variant2Action.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc60721415ef8a2a0Variant2Action? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKSharedc60721415ef8a2a0Variant2Action.Allow,
                "bypass" => AutoSDKSharedc60721415ef8a2a0Variant2Action.Bypass,
                "challenge" => AutoSDKSharedc60721415ef8a2a0Variant2Action.Challenge,
                "deny" => AutoSDKSharedc60721415ef8a2a0Variant2Action.Deny,
                "log" => AutoSDKSharedc60721415ef8a2a0Variant2Action.Log,
                "rate_limit" => AutoSDKSharedc60721415ef8a2a0Variant2Action.RateLimit,
                "redirect" => AutoSDKSharedc60721415ef8a2a0Variant2Action.Redirect,
                _ => null,
            };
        }
    }
}
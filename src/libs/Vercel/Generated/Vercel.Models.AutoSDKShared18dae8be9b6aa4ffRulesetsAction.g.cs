
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared18dae8be9b6aa4ffRulesetsAction
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
    public static class AutoSDKShared18dae8be9b6aa4ffRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared18dae8be9b6aa4ffRulesetsAction value)
        {
            return value switch
            {
                AutoSDKShared18dae8be9b6aa4ffRulesetsAction.Allow => "allow",
                AutoSDKShared18dae8be9b6aa4ffRulesetsAction.Bypass => "bypass",
                AutoSDKShared18dae8be9b6aa4ffRulesetsAction.Challenge => "challenge",
                AutoSDKShared18dae8be9b6aa4ffRulesetsAction.Deny => "deny",
                AutoSDKShared18dae8be9b6aa4ffRulesetsAction.Log => "log",
                AutoSDKShared18dae8be9b6aa4ffRulesetsAction.RateLimit => "rate_limit",
                AutoSDKShared18dae8be9b6aa4ffRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared18dae8be9b6aa4ffRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKShared18dae8be9b6aa4ffRulesetsAction.Allow,
                "bypass" => AutoSDKShared18dae8be9b6aa4ffRulesetsAction.Bypass,
                "challenge" => AutoSDKShared18dae8be9b6aa4ffRulesetsAction.Challenge,
                "deny" => AutoSDKShared18dae8be9b6aa4ffRulesetsAction.Deny,
                "log" => AutoSDKShared18dae8be9b6aa4ffRulesetsAction.Log,
                "rate_limit" => AutoSDKShared18dae8be9b6aa4ffRulesetsAction.RateLimit,
                "redirect" => AutoSDKShared18dae8be9b6aa4ffRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}
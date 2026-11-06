
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared25e1e81cf9eecd30RulesetsAction
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
    public static class AutoSDKShared25e1e81cf9eecd30RulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared25e1e81cf9eecd30RulesetsAction value)
        {
            return value switch
            {
                AutoSDKShared25e1e81cf9eecd30RulesetsAction.Allow => "allow",
                AutoSDKShared25e1e81cf9eecd30RulesetsAction.Bypass => "bypass",
                AutoSDKShared25e1e81cf9eecd30RulesetsAction.Challenge => "challenge",
                AutoSDKShared25e1e81cf9eecd30RulesetsAction.Deny => "deny",
                AutoSDKShared25e1e81cf9eecd30RulesetsAction.Log => "log",
                AutoSDKShared25e1e81cf9eecd30RulesetsAction.RateLimit => "rate_limit",
                AutoSDKShared25e1e81cf9eecd30RulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared25e1e81cf9eecd30RulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKShared25e1e81cf9eecd30RulesetsAction.Allow,
                "bypass" => AutoSDKShared25e1e81cf9eecd30RulesetsAction.Bypass,
                "challenge" => AutoSDKShared25e1e81cf9eecd30RulesetsAction.Challenge,
                "deny" => AutoSDKShared25e1e81cf9eecd30RulesetsAction.Deny,
                "log" => AutoSDKShared25e1e81cf9eecd30RulesetsAction.Log,
                "rate_limit" => AutoSDKShared25e1e81cf9eecd30RulesetsAction.RateLimit,
                "redirect" => AutoSDKShared25e1e81cf9eecd30RulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}
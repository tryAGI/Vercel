
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4c958b4a81a75558RulesetsAction
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
    public static class AutoSDKShared4c958b4a81a75558RulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4c958b4a81a75558RulesetsAction value)
        {
            return value switch
            {
                AutoSDKShared4c958b4a81a75558RulesetsAction.Allow => "allow",
                AutoSDKShared4c958b4a81a75558RulesetsAction.Bypass => "bypass",
                AutoSDKShared4c958b4a81a75558RulesetsAction.Challenge => "challenge",
                AutoSDKShared4c958b4a81a75558RulesetsAction.Deny => "deny",
                AutoSDKShared4c958b4a81a75558RulesetsAction.Log => "log",
                AutoSDKShared4c958b4a81a75558RulesetsAction.RateLimit => "rate_limit",
                AutoSDKShared4c958b4a81a75558RulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4c958b4a81a75558RulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKShared4c958b4a81a75558RulesetsAction.Allow,
                "bypass" => AutoSDKShared4c958b4a81a75558RulesetsAction.Bypass,
                "challenge" => AutoSDKShared4c958b4a81a75558RulesetsAction.Challenge,
                "deny" => AutoSDKShared4c958b4a81a75558RulesetsAction.Deny,
                "log" => AutoSDKShared4c958b4a81a75558RulesetsAction.Log,
                "rate_limit" => AutoSDKShared4c958b4a81a75558RulesetsAction.RateLimit,
                "redirect" => AutoSDKShared4c958b4a81a75558RulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}
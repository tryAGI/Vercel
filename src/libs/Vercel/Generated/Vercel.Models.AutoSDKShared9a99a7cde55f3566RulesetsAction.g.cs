
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9a99a7cde55f3566RulesetsAction
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
    public static class AutoSDKShared9a99a7cde55f3566RulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9a99a7cde55f3566RulesetsAction value)
        {
            return value switch
            {
                AutoSDKShared9a99a7cde55f3566RulesetsAction.Allow => "allow",
                AutoSDKShared9a99a7cde55f3566RulesetsAction.Bypass => "bypass",
                AutoSDKShared9a99a7cde55f3566RulesetsAction.Challenge => "challenge",
                AutoSDKShared9a99a7cde55f3566RulesetsAction.Deny => "deny",
                AutoSDKShared9a99a7cde55f3566RulesetsAction.Log => "log",
                AutoSDKShared9a99a7cde55f3566RulesetsAction.RateLimit => "rate_limit",
                AutoSDKShared9a99a7cde55f3566RulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9a99a7cde55f3566RulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKShared9a99a7cde55f3566RulesetsAction.Allow,
                "bypass" => AutoSDKShared9a99a7cde55f3566RulesetsAction.Bypass,
                "challenge" => AutoSDKShared9a99a7cde55f3566RulesetsAction.Challenge,
                "deny" => AutoSDKShared9a99a7cde55f3566RulesetsAction.Deny,
                "log" => AutoSDKShared9a99a7cde55f3566RulesetsAction.Log,
                "rate_limit" => AutoSDKShared9a99a7cde55f3566RulesetsAction.RateLimit,
                "redirect" => AutoSDKShared9a99a7cde55f3566RulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}
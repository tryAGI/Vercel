
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf0cc1038a078908fRulesetsAction
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
    public static class AutoSDKSharedf0cc1038a078908fRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf0cc1038a078908fRulesetsAction value)
        {
            return value switch
            {
                AutoSDKSharedf0cc1038a078908fRulesetsAction.Allow => "allow",
                AutoSDKSharedf0cc1038a078908fRulesetsAction.Bypass => "bypass",
                AutoSDKSharedf0cc1038a078908fRulesetsAction.Challenge => "challenge",
                AutoSDKSharedf0cc1038a078908fRulesetsAction.Deny => "deny",
                AutoSDKSharedf0cc1038a078908fRulesetsAction.Log => "log",
                AutoSDKSharedf0cc1038a078908fRulesetsAction.RateLimit => "rate_limit",
                AutoSDKSharedf0cc1038a078908fRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf0cc1038a078908fRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKSharedf0cc1038a078908fRulesetsAction.Allow,
                "bypass" => AutoSDKSharedf0cc1038a078908fRulesetsAction.Bypass,
                "challenge" => AutoSDKSharedf0cc1038a078908fRulesetsAction.Challenge,
                "deny" => AutoSDKSharedf0cc1038a078908fRulesetsAction.Deny,
                "log" => AutoSDKSharedf0cc1038a078908fRulesetsAction.Log,
                "rate_limit" => AutoSDKSharedf0cc1038a078908fRulesetsAction.RateLimit,
                "redirect" => AutoSDKSharedf0cc1038a078908fRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}
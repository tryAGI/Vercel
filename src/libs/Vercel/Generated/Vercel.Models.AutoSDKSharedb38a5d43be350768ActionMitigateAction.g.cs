
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb38a5d43be350768ActionMitigateAction
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
    public static class AutoSDKSharedb38a5d43be350768ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb38a5d43be350768ActionMitigateAction value)
        {
            return value switch
            {
                AutoSDKSharedb38a5d43be350768ActionMitigateAction.Allow => "allow",
                AutoSDKSharedb38a5d43be350768ActionMitigateAction.Bypass => "bypass",
                AutoSDKSharedb38a5d43be350768ActionMitigateAction.Challenge => "challenge",
                AutoSDKSharedb38a5d43be350768ActionMitigateAction.Deny => "deny",
                AutoSDKSharedb38a5d43be350768ActionMitigateAction.Log => "log",
                AutoSDKSharedb38a5d43be350768ActionMitigateAction.RateLimit => "rate_limit",
                AutoSDKSharedb38a5d43be350768ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb38a5d43be350768ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKSharedb38a5d43be350768ActionMitigateAction.Allow,
                "bypass" => AutoSDKSharedb38a5d43be350768ActionMitigateAction.Bypass,
                "challenge" => AutoSDKSharedb38a5d43be350768ActionMitigateAction.Challenge,
                "deny" => AutoSDKSharedb38a5d43be350768ActionMitigateAction.Deny,
                "log" => AutoSDKSharedb38a5d43be350768ActionMitigateAction.Log,
                "rate_limit" => AutoSDKSharedb38a5d43be350768ActionMitigateAction.RateLimit,
                "redirect" => AutoSDKSharedb38a5d43be350768ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}
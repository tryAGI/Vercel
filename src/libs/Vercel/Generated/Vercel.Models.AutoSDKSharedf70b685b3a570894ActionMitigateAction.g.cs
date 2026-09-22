
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedf70b685b3a570894ActionMitigateAction
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
    public static class AutoSDKSharedf70b685b3a570894ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf70b685b3a570894ActionMitigateAction value)
        {
            return value switch
            {
                AutoSDKSharedf70b685b3a570894ActionMitigateAction.Allow => "allow",
                AutoSDKSharedf70b685b3a570894ActionMitigateAction.Bypass => "bypass",
                AutoSDKSharedf70b685b3a570894ActionMitigateAction.Challenge => "challenge",
                AutoSDKSharedf70b685b3a570894ActionMitigateAction.Deny => "deny",
                AutoSDKSharedf70b685b3a570894ActionMitigateAction.Log => "log",
                AutoSDKSharedf70b685b3a570894ActionMitigateAction.RateLimit => "rate_limit",
                AutoSDKSharedf70b685b3a570894ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf70b685b3a570894ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKSharedf70b685b3a570894ActionMitigateAction.Allow,
                "bypass" => AutoSDKSharedf70b685b3a570894ActionMitigateAction.Bypass,
                "challenge" => AutoSDKSharedf70b685b3a570894ActionMitigateAction.Challenge,
                "deny" => AutoSDKSharedf70b685b3a570894ActionMitigateAction.Deny,
                "log" => AutoSDKSharedf70b685b3a570894ActionMitigateAction.Log,
                "rate_limit" => AutoSDKSharedf70b685b3a570894ActionMitigateAction.RateLimit,
                "redirect" => AutoSDKSharedf70b685b3a570894ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}
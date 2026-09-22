
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction
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
    public static class AutoSDKSharedc0ec89e0d0c59429ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction value)
        {
            return value switch
            {
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.Allow => "allow",
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.Bypass => "bypass",
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.Challenge => "challenge",
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.Deny => "deny",
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.Log => "log",
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.RateLimit => "rate_limit",
                AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.Allow,
                "bypass" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.Bypass,
                "challenge" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.Challenge,
                "deny" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.Deny,
                "log" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.Log,
                "rate_limit" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.RateLimit,
                "redirect" => AutoSDKSharedc0ec89e0d0c59429ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}
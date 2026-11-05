
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede10df3c22a339c10ActionMitigateAction
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
    public static class AutoSDKSharede10df3c22a339c10ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede10df3c22a339c10ActionMitigateAction value)
        {
            return value switch
            {
                AutoSDKSharede10df3c22a339c10ActionMitigateAction.Allow => "allow",
                AutoSDKSharede10df3c22a339c10ActionMitigateAction.Bypass => "bypass",
                AutoSDKSharede10df3c22a339c10ActionMitigateAction.Challenge => "challenge",
                AutoSDKSharede10df3c22a339c10ActionMitigateAction.Deny => "deny",
                AutoSDKSharede10df3c22a339c10ActionMitigateAction.Log => "log",
                AutoSDKSharede10df3c22a339c10ActionMitigateAction.RateLimit => "rate_limit",
                AutoSDKSharede10df3c22a339c10ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede10df3c22a339c10ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKSharede10df3c22a339c10ActionMitigateAction.Allow,
                "bypass" => AutoSDKSharede10df3c22a339c10ActionMitigateAction.Bypass,
                "challenge" => AutoSDKSharede10df3c22a339c10ActionMitigateAction.Challenge,
                "deny" => AutoSDKSharede10df3c22a339c10ActionMitigateAction.Deny,
                "log" => AutoSDKSharede10df3c22a339c10ActionMitigateAction.Log,
                "rate_limit" => AutoSDKSharede10df3c22a339c10ActionMitigateAction.RateLimit,
                "redirect" => AutoSDKSharede10df3c22a339c10ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}
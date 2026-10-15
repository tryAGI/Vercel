
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared17a9bc9c3c063edbActionMitigateAction
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
    public static class AutoSDKShared17a9bc9c3c063edbActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared17a9bc9c3c063edbActionMitigateAction value)
        {
            return value switch
            {
                AutoSDKShared17a9bc9c3c063edbActionMitigateAction.Allow => "allow",
                AutoSDKShared17a9bc9c3c063edbActionMitigateAction.Bypass => "bypass",
                AutoSDKShared17a9bc9c3c063edbActionMitigateAction.Challenge => "challenge",
                AutoSDKShared17a9bc9c3c063edbActionMitigateAction.Deny => "deny",
                AutoSDKShared17a9bc9c3c063edbActionMitigateAction.Log => "log",
                AutoSDKShared17a9bc9c3c063edbActionMitigateAction.RateLimit => "rate_limit",
                AutoSDKShared17a9bc9c3c063edbActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared17a9bc9c3c063edbActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKShared17a9bc9c3c063edbActionMitigateAction.Allow,
                "bypass" => AutoSDKShared17a9bc9c3c063edbActionMitigateAction.Bypass,
                "challenge" => AutoSDKShared17a9bc9c3c063edbActionMitigateAction.Challenge,
                "deny" => AutoSDKShared17a9bc9c3c063edbActionMitigateAction.Deny,
                "log" => AutoSDKShared17a9bc9c3c063edbActionMitigateAction.Log,
                "rate_limit" => AutoSDKShared17a9bc9c3c063edbActionMitigateAction.RateLimit,
                "redirect" => AutoSDKShared17a9bc9c3c063edbActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}
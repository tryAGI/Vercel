
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared44c5e53073934a2bActionMitigateAction
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
    public static class AutoSDKShared44c5e53073934a2bActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared44c5e53073934a2bActionMitigateAction value)
        {
            return value switch
            {
                AutoSDKShared44c5e53073934a2bActionMitigateAction.Allow => "allow",
                AutoSDKShared44c5e53073934a2bActionMitigateAction.Bypass => "bypass",
                AutoSDKShared44c5e53073934a2bActionMitigateAction.Challenge => "challenge",
                AutoSDKShared44c5e53073934a2bActionMitigateAction.Deny => "deny",
                AutoSDKShared44c5e53073934a2bActionMitigateAction.Log => "log",
                AutoSDKShared44c5e53073934a2bActionMitigateAction.RateLimit => "rate_limit",
                AutoSDKShared44c5e53073934a2bActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared44c5e53073934a2bActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKShared44c5e53073934a2bActionMitigateAction.Allow,
                "bypass" => AutoSDKShared44c5e53073934a2bActionMitigateAction.Bypass,
                "challenge" => AutoSDKShared44c5e53073934a2bActionMitigateAction.Challenge,
                "deny" => AutoSDKShared44c5e53073934a2bActionMitigateAction.Deny,
                "log" => AutoSDKShared44c5e53073934a2bActionMitigateAction.Log,
                "rate_limit" => AutoSDKShared44c5e53073934a2bActionMitigateAction.RateLimit,
                "redirect" => AutoSDKShared44c5e53073934a2bActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}
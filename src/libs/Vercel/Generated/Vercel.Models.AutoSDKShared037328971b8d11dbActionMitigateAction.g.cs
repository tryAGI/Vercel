
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared037328971b8d11dbActionMitigateAction
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
    public static class AutoSDKShared037328971b8d11dbActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared037328971b8d11dbActionMitigateAction value)
        {
            return value switch
            {
                AutoSDKShared037328971b8d11dbActionMitigateAction.Allow => "allow",
                AutoSDKShared037328971b8d11dbActionMitigateAction.Bypass => "bypass",
                AutoSDKShared037328971b8d11dbActionMitigateAction.Challenge => "challenge",
                AutoSDKShared037328971b8d11dbActionMitigateAction.Deny => "deny",
                AutoSDKShared037328971b8d11dbActionMitigateAction.Log => "log",
                AutoSDKShared037328971b8d11dbActionMitigateAction.RateLimit => "rate_limit",
                AutoSDKShared037328971b8d11dbActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared037328971b8d11dbActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKShared037328971b8d11dbActionMitigateAction.Allow,
                "bypass" => AutoSDKShared037328971b8d11dbActionMitigateAction.Bypass,
                "challenge" => AutoSDKShared037328971b8d11dbActionMitigateAction.Challenge,
                "deny" => AutoSDKShared037328971b8d11dbActionMitigateAction.Deny,
                "log" => AutoSDKShared037328971b8d11dbActionMitigateAction.Log,
                "rate_limit" => AutoSDKShared037328971b8d11dbActionMitigateAction.RateLimit,
                "redirect" => AutoSDKShared037328971b8d11dbActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}
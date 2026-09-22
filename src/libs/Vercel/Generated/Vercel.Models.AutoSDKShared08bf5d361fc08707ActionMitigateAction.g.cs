
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared08bf5d361fc08707ActionMitigateAction
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
    public static class AutoSDKShared08bf5d361fc08707ActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared08bf5d361fc08707ActionMitigateAction value)
        {
            return value switch
            {
                AutoSDKShared08bf5d361fc08707ActionMitigateAction.Allow => "allow",
                AutoSDKShared08bf5d361fc08707ActionMitigateAction.Bypass => "bypass",
                AutoSDKShared08bf5d361fc08707ActionMitigateAction.Challenge => "challenge",
                AutoSDKShared08bf5d361fc08707ActionMitigateAction.Deny => "deny",
                AutoSDKShared08bf5d361fc08707ActionMitigateAction.Log => "log",
                AutoSDKShared08bf5d361fc08707ActionMitigateAction.RateLimit => "rate_limit",
                AutoSDKShared08bf5d361fc08707ActionMitigateAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared08bf5d361fc08707ActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => AutoSDKShared08bf5d361fc08707ActionMitigateAction.Allow,
                "bypass" => AutoSDKShared08bf5d361fc08707ActionMitigateAction.Bypass,
                "challenge" => AutoSDKShared08bf5d361fc08707ActionMitigateAction.Challenge,
                "deny" => AutoSDKShared08bf5d361fc08707ActionMitigateAction.Deny,
                "log" => AutoSDKShared08bf5d361fc08707ActionMitigateAction.Log,
                "rate_limit" => AutoSDKShared08bf5d361fc08707ActionMitigateAction.RateLimit,
                "redirect" => AutoSDKShared08bf5d361fc08707ActionMitigateAction.Redirect,
                _ => null,
            };
        }
    }
}
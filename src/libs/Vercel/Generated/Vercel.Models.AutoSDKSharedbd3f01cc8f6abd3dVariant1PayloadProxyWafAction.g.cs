
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction value)
        {
            return value switch
            {
                AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction.Bypass => "bypass",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction.Challenge => "challenge",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction.Deny => "deny",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction.Log => "log",
                AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction.Bypass,
                "challenge" => AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction.Challenge,
                "deny" => AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction.Deny,
                "log" => AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction.Log,
                "rate_limit" => AutoSDKSharedbd3f01cc8f6abd3dVariant1PayloadProxyWafAction.RateLimit,
                _ => null,
            };
        }
    }
}
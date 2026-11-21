
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction
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
    public static class AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction value)
        {
            return value switch
            {
                AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction.Bypass => "bypass",
                AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction.Challenge => "challenge",
                AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction.Deny => "deny",
                AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction.Log => "log",
                AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction.Bypass,
                "challenge" => AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction.Challenge,
                "deny" => AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction.Deny,
                "log" => AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction.Log,
                "rate_limit" => AutoSDKSharedcf426121243a64beVariant1PayloadProxyWafAction.RateLimit,
                _ => null,
            };
        }
    }
}
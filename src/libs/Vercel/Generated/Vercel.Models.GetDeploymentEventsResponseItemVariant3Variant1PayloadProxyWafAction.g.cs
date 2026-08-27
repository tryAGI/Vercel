
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction
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
    public static class GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction value)
        {
            return value switch
            {
                GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction.Bypass => "bypass",
                GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction.Challenge => "challenge",
                GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction.Deny => "deny",
                GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction.Log => "log",
                GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction.Bypass,
                "challenge" => GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction.Challenge,
                "deny" => GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction.Deny,
                "log" => GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction.Log,
                "rate_limit" => GetDeploymentEventsResponseItemVariant3Variant1PayloadProxyWafAction.RateLimit,
                _ => null,
            };
        }
    }
}
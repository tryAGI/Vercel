
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction
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
    public static class GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction value)
        {
            return value switch
            {
                GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction.Bypass => "bypass",
                GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction.Challenge => "challenge",
                GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction.Deny => "deny",
                GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction.Log => "log",
                GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction.Bypass,
                "challenge" => GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction.Challenge,
                "deny" => GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction.Deny,
                "log" => GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction.Log,
                "rate_limit" => GetDeploymentEventsResponseVariant3Variant1PayloadProxyWafAction.RateLimit,
                _ => null,
            };
        }
    }
}
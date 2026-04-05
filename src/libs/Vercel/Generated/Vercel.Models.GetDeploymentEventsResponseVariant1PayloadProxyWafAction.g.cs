
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseVariant1PayloadProxyWafAction
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
    public static class GetDeploymentEventsResponseVariant1PayloadProxyWafActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseVariant1PayloadProxyWafAction value)
        {
            return value switch
            {
                GetDeploymentEventsResponseVariant1PayloadProxyWafAction.Bypass => "bypass",
                GetDeploymentEventsResponseVariant1PayloadProxyWafAction.Challenge => "challenge",
                GetDeploymentEventsResponseVariant1PayloadProxyWafAction.Deny => "deny",
                GetDeploymentEventsResponseVariant1PayloadProxyWafAction.Log => "log",
                GetDeploymentEventsResponseVariant1PayloadProxyWafAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseVariant1PayloadProxyWafAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetDeploymentEventsResponseVariant1PayloadProxyWafAction.Bypass,
                "challenge" => GetDeploymentEventsResponseVariant1PayloadProxyWafAction.Challenge,
                "deny" => GetDeploymentEventsResponseVariant1PayloadProxyWafAction.Deny,
                "log" => GetDeploymentEventsResponseVariant1PayloadProxyWafAction.Log,
                "rate_limit" => GetDeploymentEventsResponseVariant1PayloadProxyWafAction.RateLimit,
                _ => null,
            };
        }
    }
}
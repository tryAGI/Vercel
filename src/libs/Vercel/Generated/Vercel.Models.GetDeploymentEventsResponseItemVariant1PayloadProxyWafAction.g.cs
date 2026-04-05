
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction
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
    public static class GetDeploymentEventsResponseItemVariant1PayloadProxyWafActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction value)
        {
            return value switch
            {
                GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction.Bypass => "bypass",
                GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction.Challenge => "challenge",
                GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction.Deny => "deny",
                GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction.Log => "log",
                GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction.RateLimit => "rate_limit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction.Bypass,
                "challenge" => GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction.Challenge,
                "deny" => GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction.Deny,
                "log" => GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction.Log,
                "rate_limit" => GetDeploymentEventsResponseItemVariant1PayloadProxyWafAction.RateLimit,
                _ => null,
            };
        }
    }
}
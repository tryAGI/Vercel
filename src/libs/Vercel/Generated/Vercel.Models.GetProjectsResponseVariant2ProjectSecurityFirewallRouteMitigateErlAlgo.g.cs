
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateErlAlgo
    {
        /// <summary>
        /// 
        /// </summary>
        FixedWindow,
        /// <summary>
        /// 
        /// </summary>
        TokenBucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateErlAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateErlAlgo value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateErlAlgo.FixedWindow => "fixed_window",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateErlAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateErlAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateErlAlgo.FixedWindow,
                "token_bucket" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteMitigateErlAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}
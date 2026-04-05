
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErlAlgo
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
    public static class GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErlAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErlAlgo value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErlAlgo.FixedWindow => "fixed_window",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErlAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErlAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErlAlgo.FixedWindow,
                "token_bucket" => GetProjectsResponseVariant1ItemSecurityFirewallRouteMitigateErlAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}
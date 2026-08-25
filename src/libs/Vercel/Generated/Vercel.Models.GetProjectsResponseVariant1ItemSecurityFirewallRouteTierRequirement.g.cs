
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement
    {
        /// <summary>
        /// 
        /// </summary>
        Advanced,
        /// <summary>
        /// 
        /// </summary>
        Critical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement.Advanced => "advanced",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement.Critical => "critical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement.Advanced,
                "critical" => GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement.Critical,
                _ => null,
            };
        }
    }
}
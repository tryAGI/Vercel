
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityFirewallRouteTierRequirement
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
    public static class GetProjectsResponseVariant2ProjectSecurityFirewallRouteTierRequirementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityFirewallRouteTierRequirement value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteTierRequirement.Advanced => "advanced",
                GetProjectsResponseVariant2ProjectSecurityFirewallRouteTierRequirement.Critical => "critical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityFirewallRouteTierRequirement? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteTierRequirement.Advanced,
                "critical" => GetProjectsResponseVariant2ProjectSecurityFirewallRouteTierRequirement.Critical,
                _ => null,
            };
        }
    }
}
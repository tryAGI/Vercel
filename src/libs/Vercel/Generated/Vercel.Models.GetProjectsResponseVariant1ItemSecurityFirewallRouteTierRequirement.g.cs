
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
        Critical,
        /// <summary>
        ///
        /// </summary>
        Priority,
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
                GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement.Critical => "critical",
                GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement.Priority => "priority",
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
                "critical" => GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement.Critical,
                "priority" => GetProjectsResponseVariant1ItemSecurityFirewallRouteTierRequirement.Priority,
                _ => null,
            };
        }
    }
}
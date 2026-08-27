
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityManagedRulesTrafficSourcesAction
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemSecurityManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityManagedRulesTrafficSourcesAction.Challenge => "challenge",
                GetProjectsResponseVariant1ItemSecurityManagedRulesTrafficSourcesAction.Deny => "deny",
                GetProjectsResponseVariant1ItemSecurityManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant1ItemSecurityManagedRulesTrafficSourcesAction.Challenge,
                "deny" => GetProjectsResponseVariant1ItemSecurityManagedRulesTrafficSourcesAction.Deny,
                "log" => GetProjectsResponseVariant1ItemSecurityManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}
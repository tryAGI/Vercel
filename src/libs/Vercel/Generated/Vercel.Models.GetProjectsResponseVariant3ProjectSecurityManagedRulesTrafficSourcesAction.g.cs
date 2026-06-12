
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesAction
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
    public static class GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesAction.Challenge => "challenge",
                GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesAction.Deny => "deny",
                GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesAction.Challenge,
                "deny" => GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesAction.Deny,
                "log" => GetProjectsResponseVariant3ProjectSecurityManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}
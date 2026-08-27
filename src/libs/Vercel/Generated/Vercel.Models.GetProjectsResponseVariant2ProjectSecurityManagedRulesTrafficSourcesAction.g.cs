
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityManagedRulesTrafficSourcesAction
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
    public static class GetProjectsResponseVariant2ProjectSecurityManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityManagedRulesTrafficSourcesAction.Challenge => "challenge",
                GetProjectsResponseVariant2ProjectSecurityManagedRulesTrafficSourcesAction.Deny => "deny",
                GetProjectsResponseVariant2ProjectSecurityManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant2ProjectSecurityManagedRulesTrafficSourcesAction.Challenge,
                "deny" => GetProjectsResponseVariant2ProjectSecurityManagedRulesTrafficSourcesAction.Deny,
                "log" => GetProjectsResponseVariant2ProjectSecurityManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}
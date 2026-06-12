
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseSecurityManagedRulesTrafficSourcesAction
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
    public static class GetProjectResponseSecurityManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSecurityManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                GetProjectResponseSecurityManagedRulesTrafficSourcesAction.Challenge => "challenge",
                GetProjectResponseSecurityManagedRulesTrafficSourcesAction.Deny => "deny",
                GetProjectResponseSecurityManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSecurityManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectResponseSecurityManagedRulesTrafficSourcesAction.Challenge,
                "deny" => GetProjectResponseSecurityManagedRulesTrafficSourcesAction.Deny,
                "log" => GetProjectResponseSecurityManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityManagedRulesOwaspAction
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
    public static class GetProjectsResponseVariant1ItemSecurityManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityManagedRulesOwaspAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityManagedRulesOwaspAction.Challenge => "challenge",
                GetProjectsResponseVariant1ItemSecurityManagedRulesOwaspAction.Deny => "deny",
                GetProjectsResponseVariant1ItemSecurityManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant1ItemSecurityManagedRulesOwaspAction.Challenge,
                "deny" => GetProjectsResponseVariant1ItemSecurityManagedRulesOwaspAction.Deny,
                "log" => GetProjectsResponseVariant1ItemSecurityManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSecurityManagedRulesOwaspAction
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
    public static class GetProjectsResponseVariant3ProjectSecurityManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSecurityManagedRulesOwaspAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSecurityManagedRulesOwaspAction.Challenge => "challenge",
                GetProjectsResponseVariant3ProjectSecurityManagedRulesOwaspAction.Deny => "deny",
                GetProjectsResponseVariant3ProjectSecurityManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSecurityManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant3ProjectSecurityManagedRulesOwaspAction.Challenge,
                "deny" => GetProjectsResponseVariant3ProjectSecurityManagedRulesOwaspAction.Deny,
                "log" => GetProjectsResponseVariant3ProjectSecurityManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}
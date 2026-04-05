
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityManagedRulesOwaspAction
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
    public static class GetProjectsResponseVariant2ProjectSecurityManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityManagedRulesOwaspAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityManagedRulesOwaspAction.Challenge => "challenge",
                GetProjectsResponseVariant2ProjectSecurityManagedRulesOwaspAction.Deny => "deny",
                GetProjectsResponseVariant2ProjectSecurityManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant2ProjectSecurityManagedRulesOwaspAction.Challenge,
                "deny" => GetProjectsResponseVariant2ProjectSecurityManagedRulesOwaspAction.Deny,
                "log" => GetProjectsResponseVariant2ProjectSecurityManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}
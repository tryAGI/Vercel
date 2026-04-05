
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSecurityManagedRulesVercelRulesetAction
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
    public static class GetProjectsResponseVariant3ProjectSecurityManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSecurityManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSecurityManagedRulesVercelRulesetAction.Challenge => "challenge",
                GetProjectsResponseVariant3ProjectSecurityManagedRulesVercelRulesetAction.Deny => "deny",
                GetProjectsResponseVariant3ProjectSecurityManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSecurityManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant3ProjectSecurityManagedRulesVercelRulesetAction.Challenge,
                "deny" => GetProjectsResponseVariant3ProjectSecurityManagedRulesVercelRulesetAction.Deny,
                "log" => GetProjectsResponseVariant3ProjectSecurityManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}
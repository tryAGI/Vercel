
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityManagedRulesVercelRulesetAction
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
    public static class GetProjectsResponseVariant2ProjectSecurityManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityManagedRulesVercelRulesetAction.Challenge => "challenge",
                GetProjectsResponseVariant2ProjectSecurityManagedRulesVercelRulesetAction.Deny => "deny",
                GetProjectsResponseVariant2ProjectSecurityManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant2ProjectSecurityManagedRulesVercelRulesetAction.Challenge,
                "deny" => GetProjectsResponseVariant2ProjectSecurityManagedRulesVercelRulesetAction.Deny,
                "log" => GetProjectsResponseVariant2ProjectSecurityManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction
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
    public static class GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction.Challenge => "challenge",
                GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction.Deny => "deny",
                GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction.Challenge,
                "deny" => GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction.Deny,
                "log" => GetProjectsResponseVariant1ItemSecurityManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}
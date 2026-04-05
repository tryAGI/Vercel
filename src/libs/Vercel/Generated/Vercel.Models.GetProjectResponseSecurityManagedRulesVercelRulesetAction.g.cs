
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseSecurityManagedRulesVercelRulesetAction
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
    public static class GetProjectResponseSecurityManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSecurityManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                GetProjectResponseSecurityManagedRulesVercelRulesetAction.Challenge => "challenge",
                GetProjectResponseSecurityManagedRulesVercelRulesetAction.Deny => "deny",
                GetProjectResponseSecurityManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSecurityManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectResponseSecurityManagedRulesVercelRulesetAction.Challenge,
                "deny" => GetProjectResponseSecurityManagedRulesVercelRulesetAction.Deny,
                "log" => GetProjectResponseSecurityManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}
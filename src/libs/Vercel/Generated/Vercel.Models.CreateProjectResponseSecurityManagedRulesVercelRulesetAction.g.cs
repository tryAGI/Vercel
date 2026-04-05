
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseSecurityManagedRulesVercelRulesetAction
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
    public static class CreateProjectResponseSecurityManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSecurityManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                CreateProjectResponseSecurityManagedRulesVercelRulesetAction.Challenge => "challenge",
                CreateProjectResponseSecurityManagedRulesVercelRulesetAction.Deny => "deny",
                CreateProjectResponseSecurityManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSecurityManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateProjectResponseSecurityManagedRulesVercelRulesetAction.Challenge,
                "deny" => CreateProjectResponseSecurityManagedRulesVercelRulesetAction.Deny,
                "log" => CreateProjectResponseSecurityManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}
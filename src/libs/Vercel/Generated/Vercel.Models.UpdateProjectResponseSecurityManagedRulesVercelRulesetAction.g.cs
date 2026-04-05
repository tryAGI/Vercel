
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseSecurityManagedRulesVercelRulesetAction
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
    public static class UpdateProjectResponseSecurityManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSecurityManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                UpdateProjectResponseSecurityManagedRulesVercelRulesetAction.Challenge => "challenge",
                UpdateProjectResponseSecurityManagedRulesVercelRulesetAction.Deny => "deny",
                UpdateProjectResponseSecurityManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSecurityManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateProjectResponseSecurityManagedRulesVercelRulesetAction.Challenge,
                "deny" => UpdateProjectResponseSecurityManagedRulesVercelRulesetAction.Deny,
                "log" => UpdateProjectResponseSecurityManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}
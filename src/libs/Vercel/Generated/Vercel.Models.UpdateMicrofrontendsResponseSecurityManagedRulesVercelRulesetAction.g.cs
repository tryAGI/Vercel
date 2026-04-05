
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseSecurityManagedRulesVercelRulesetAction
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
    public static class UpdateMicrofrontendsResponseSecurityManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSecurityManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSecurityManagedRulesVercelRulesetAction.Challenge => "challenge",
                UpdateMicrofrontendsResponseSecurityManagedRulesVercelRulesetAction.Deny => "deny",
                UpdateMicrofrontendsResponseSecurityManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSecurityManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateMicrofrontendsResponseSecurityManagedRulesVercelRulesetAction.Challenge,
                "deny" => UpdateMicrofrontendsResponseSecurityManagedRulesVercelRulesetAction.Deny,
                "log" => UpdateMicrofrontendsResponseSecurityManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}
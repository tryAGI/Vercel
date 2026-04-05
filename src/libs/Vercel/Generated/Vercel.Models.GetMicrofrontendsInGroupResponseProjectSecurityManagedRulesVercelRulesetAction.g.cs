
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesVercelRulesetAction
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
    public static class GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesVercelRulesetAction.Challenge => "challenge",
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesVercelRulesetAction.Deny => "deny",
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesVercelRulesetAction.Challenge,
                "deny" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesVercelRulesetAction.Deny,
                "log" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}
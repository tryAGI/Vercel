
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesAiBotsAction
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
    public static class GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesAiBotsAction value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesAiBotsAction.Challenge => "challenge",
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesAiBotsAction.Deny => "deny",
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesAiBotsAction.Challenge,
                "deny" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesAiBotsAction.Deny,
                "log" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}
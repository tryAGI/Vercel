
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesBotFilterAction
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
    public static class GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesBotFilterAction value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesBotFilterAction.Challenge => "challenge",
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesBotFilterAction.Deny => "deny",
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesBotFilterAction.Challenge,
                "deny" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesBotFilterAction.Deny,
                "log" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}
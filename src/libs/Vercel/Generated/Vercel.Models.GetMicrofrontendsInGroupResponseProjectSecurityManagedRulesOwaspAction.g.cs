
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesOwaspAction
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
    public static class GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesOwaspAction value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesOwaspAction.Challenge => "challenge",
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesOwaspAction.Deny => "deny",
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesOwaspAction.Challenge,
                "deny" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesOwaspAction.Deny,
                "log" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesTrafficSourcesAction
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
    public static class GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesTrafficSourcesAction.Challenge => "challenge",
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesTrafficSourcesAction.Deny => "deny",
                GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesTrafficSourcesAction.Challenge,
                "deny" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesTrafficSourcesAction.Deny,
                "log" => GetMicrofrontendsInGroupResponseProjectSecurityManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}
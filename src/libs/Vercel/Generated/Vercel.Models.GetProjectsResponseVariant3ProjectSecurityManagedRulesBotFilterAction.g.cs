
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSecurityManagedRulesBotFilterAction
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
    public static class GetProjectsResponseVariant3ProjectSecurityManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSecurityManagedRulesBotFilterAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSecurityManagedRulesBotFilterAction.Challenge => "challenge",
                GetProjectsResponseVariant3ProjectSecurityManagedRulesBotFilterAction.Deny => "deny",
                GetProjectsResponseVariant3ProjectSecurityManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSecurityManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant3ProjectSecurityManagedRulesBotFilterAction.Challenge,
                "deny" => GetProjectsResponseVariant3ProjectSecurityManagedRulesBotFilterAction.Deny,
                "log" => GetProjectsResponseVariant3ProjectSecurityManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}
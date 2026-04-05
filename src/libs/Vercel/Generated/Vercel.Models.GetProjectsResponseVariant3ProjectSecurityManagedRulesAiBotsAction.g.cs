
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSecurityManagedRulesAiBotsAction
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
    public static class GetProjectsResponseVariant3ProjectSecurityManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSecurityManagedRulesAiBotsAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSecurityManagedRulesAiBotsAction.Challenge => "challenge",
                GetProjectsResponseVariant3ProjectSecurityManagedRulesAiBotsAction.Deny => "deny",
                GetProjectsResponseVariant3ProjectSecurityManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSecurityManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant3ProjectSecurityManagedRulesAiBotsAction.Challenge,
                "deny" => GetProjectsResponseVariant3ProjectSecurityManagedRulesAiBotsAction.Deny,
                "log" => GetProjectsResponseVariant3ProjectSecurityManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}
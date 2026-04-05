
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityManagedRulesAiBotsAction
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
    public static class GetProjectsResponseVariant2ProjectSecurityManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityManagedRulesAiBotsAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityManagedRulesAiBotsAction.Challenge => "challenge",
                GetProjectsResponseVariant2ProjectSecurityManagedRulesAiBotsAction.Deny => "deny",
                GetProjectsResponseVariant2ProjectSecurityManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant2ProjectSecurityManagedRulesAiBotsAction.Challenge,
                "deny" => GetProjectsResponseVariant2ProjectSecurityManagedRulesAiBotsAction.Deny,
                "log" => GetProjectsResponseVariant2ProjectSecurityManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityManagedRulesAiBotsAction
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
    public static class GetProjectsResponseVariant1ItemSecurityManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityManagedRulesAiBotsAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityManagedRulesAiBotsAction.Challenge => "challenge",
                GetProjectsResponseVariant1ItemSecurityManagedRulesAiBotsAction.Deny => "deny",
                GetProjectsResponseVariant1ItemSecurityManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant1ItemSecurityManagedRulesAiBotsAction.Challenge,
                "deny" => GetProjectsResponseVariant1ItemSecurityManagedRulesAiBotsAction.Deny,
                "log" => GetProjectsResponseVariant1ItemSecurityManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}
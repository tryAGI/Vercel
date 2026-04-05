
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseSecurityManagedRulesAiBotsAction
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
    public static class GetProjectResponseSecurityManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSecurityManagedRulesAiBotsAction value)
        {
            return value switch
            {
                GetProjectResponseSecurityManagedRulesAiBotsAction.Challenge => "challenge",
                GetProjectResponseSecurityManagedRulesAiBotsAction.Deny => "deny",
                GetProjectResponseSecurityManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSecurityManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectResponseSecurityManagedRulesAiBotsAction.Challenge,
                "deny" => GetProjectResponseSecurityManagedRulesAiBotsAction.Deny,
                "log" => GetProjectResponseSecurityManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}
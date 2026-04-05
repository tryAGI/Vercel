
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseSecurityManagedRulesAiBotsAction
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
    public static class CreateProjectResponseSecurityManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSecurityManagedRulesAiBotsAction value)
        {
            return value switch
            {
                CreateProjectResponseSecurityManagedRulesAiBotsAction.Challenge => "challenge",
                CreateProjectResponseSecurityManagedRulesAiBotsAction.Deny => "deny",
                CreateProjectResponseSecurityManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSecurityManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateProjectResponseSecurityManagedRulesAiBotsAction.Challenge,
                "deny" => CreateProjectResponseSecurityManagedRulesAiBotsAction.Deny,
                "log" => CreateProjectResponseSecurityManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}
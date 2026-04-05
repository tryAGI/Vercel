
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseSecurityManagedRulesAiBotsAction
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
    public static class UpdateProjectResponseSecurityManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSecurityManagedRulesAiBotsAction value)
        {
            return value switch
            {
                UpdateProjectResponseSecurityManagedRulesAiBotsAction.Challenge => "challenge",
                UpdateProjectResponseSecurityManagedRulesAiBotsAction.Deny => "deny",
                UpdateProjectResponseSecurityManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSecurityManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateProjectResponseSecurityManagedRulesAiBotsAction.Challenge,
                "deny" => UpdateProjectResponseSecurityManagedRulesAiBotsAction.Deny,
                "log" => UpdateProjectResponseSecurityManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}
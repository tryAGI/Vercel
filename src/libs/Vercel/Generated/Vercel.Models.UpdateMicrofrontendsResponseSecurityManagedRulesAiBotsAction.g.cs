
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseSecurityManagedRulesAiBotsAction
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
    public static class UpdateMicrofrontendsResponseSecurityManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSecurityManagedRulesAiBotsAction value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSecurityManagedRulesAiBotsAction.Challenge => "challenge",
                UpdateMicrofrontendsResponseSecurityManagedRulesAiBotsAction.Deny => "deny",
                UpdateMicrofrontendsResponseSecurityManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSecurityManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateMicrofrontendsResponseSecurityManagedRulesAiBotsAction.Challenge,
                "deny" => UpdateMicrofrontendsResponseSecurityManagedRulesAiBotsAction.Deny,
                "log" => UpdateMicrofrontendsResponseSecurityManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseSecurityManagedRulesBotFilterAction
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
    public static class UpdateMicrofrontendsResponseSecurityManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSecurityManagedRulesBotFilterAction value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSecurityManagedRulesBotFilterAction.Challenge => "challenge",
                UpdateMicrofrontendsResponseSecurityManagedRulesBotFilterAction.Deny => "deny",
                UpdateMicrofrontendsResponseSecurityManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSecurityManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateMicrofrontendsResponseSecurityManagedRulesBotFilterAction.Challenge,
                "deny" => UpdateMicrofrontendsResponseSecurityManagedRulesBotFilterAction.Deny,
                "log" => UpdateMicrofrontendsResponseSecurityManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}
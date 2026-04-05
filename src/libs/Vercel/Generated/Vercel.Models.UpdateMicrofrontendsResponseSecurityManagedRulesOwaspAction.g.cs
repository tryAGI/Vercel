
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseSecurityManagedRulesOwaspAction
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
    public static class UpdateMicrofrontendsResponseSecurityManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSecurityManagedRulesOwaspAction value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSecurityManagedRulesOwaspAction.Challenge => "challenge",
                UpdateMicrofrontendsResponseSecurityManagedRulesOwaspAction.Deny => "deny",
                UpdateMicrofrontendsResponseSecurityManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSecurityManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateMicrofrontendsResponseSecurityManagedRulesOwaspAction.Challenge,
                "deny" => UpdateMicrofrontendsResponseSecurityManagedRulesOwaspAction.Deny,
                "log" => UpdateMicrofrontendsResponseSecurityManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}
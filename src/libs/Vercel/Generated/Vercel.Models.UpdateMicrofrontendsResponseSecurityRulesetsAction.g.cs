
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseSecurityRulesetsAction
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Bypass,
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
        /// <summary>
        ///
        /// </summary>
        RateLimit,
        /// <summary>
        ///
        /// </summary>
        Redirect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseSecurityRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSecurityRulesetsAction value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSecurityRulesetsAction.Allow => "allow",
                UpdateMicrofrontendsResponseSecurityRulesetsAction.Bypass => "bypass",
                UpdateMicrofrontendsResponseSecurityRulesetsAction.Challenge => "challenge",
                UpdateMicrofrontendsResponseSecurityRulesetsAction.Deny => "deny",
                UpdateMicrofrontendsResponseSecurityRulesetsAction.Log => "log",
                UpdateMicrofrontendsResponseSecurityRulesetsAction.RateLimit => "rate_limit",
                UpdateMicrofrontendsResponseSecurityRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSecurityRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => UpdateMicrofrontendsResponseSecurityRulesetsAction.Allow,
                "bypass" => UpdateMicrofrontendsResponseSecurityRulesetsAction.Bypass,
                "challenge" => UpdateMicrofrontendsResponseSecurityRulesetsAction.Challenge,
                "deny" => UpdateMicrofrontendsResponseSecurityRulesetsAction.Deny,
                "log" => UpdateMicrofrontendsResponseSecurityRulesetsAction.Log,
                "rate_limit" => UpdateMicrofrontendsResponseSecurityRulesetsAction.RateLimit,
                "redirect" => UpdateMicrofrontendsResponseSecurityRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectResponseSecurityRulesetsAction
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
    public static class UpdateProjectResponseSecurityRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSecurityRulesetsAction value)
        {
            return value switch
            {
                UpdateProjectResponseSecurityRulesetsAction.Allow => "allow",
                UpdateProjectResponseSecurityRulesetsAction.Bypass => "bypass",
                UpdateProjectResponseSecurityRulesetsAction.Challenge => "challenge",
                UpdateProjectResponseSecurityRulesetsAction.Deny => "deny",
                UpdateProjectResponseSecurityRulesetsAction.Log => "log",
                UpdateProjectResponseSecurityRulesetsAction.RateLimit => "rate_limit",
                UpdateProjectResponseSecurityRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSecurityRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => UpdateProjectResponseSecurityRulesetsAction.Allow,
                "bypass" => UpdateProjectResponseSecurityRulesetsAction.Bypass,
                "challenge" => UpdateProjectResponseSecurityRulesetsAction.Challenge,
                "deny" => UpdateProjectResponseSecurityRulesetsAction.Deny,
                "log" => UpdateProjectResponseSecurityRulesetsAction.Log,
                "rate_limit" => UpdateProjectResponseSecurityRulesetsAction.RateLimit,
                "redirect" => UpdateProjectResponseSecurityRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}
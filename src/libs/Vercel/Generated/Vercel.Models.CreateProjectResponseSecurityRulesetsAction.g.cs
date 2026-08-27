
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseSecurityRulesetsAction
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
    public static class CreateProjectResponseSecurityRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSecurityRulesetsAction value)
        {
            return value switch
            {
                CreateProjectResponseSecurityRulesetsAction.Allow => "allow",
                CreateProjectResponseSecurityRulesetsAction.Bypass => "bypass",
                CreateProjectResponseSecurityRulesetsAction.Challenge => "challenge",
                CreateProjectResponseSecurityRulesetsAction.Deny => "deny",
                CreateProjectResponseSecurityRulesetsAction.Log => "log",
                CreateProjectResponseSecurityRulesetsAction.RateLimit => "rate_limit",
                CreateProjectResponseSecurityRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSecurityRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => CreateProjectResponseSecurityRulesetsAction.Allow,
                "bypass" => CreateProjectResponseSecurityRulesetsAction.Bypass,
                "challenge" => CreateProjectResponseSecurityRulesetsAction.Challenge,
                "deny" => CreateProjectResponseSecurityRulesetsAction.Deny,
                "log" => CreateProjectResponseSecurityRulesetsAction.Log,
                "rate_limit" => CreateProjectResponseSecurityRulesetsAction.RateLimit,
                "redirect" => CreateProjectResponseSecurityRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}
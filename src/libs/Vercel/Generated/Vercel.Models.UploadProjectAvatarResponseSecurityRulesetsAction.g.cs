
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseSecurityRulesetsAction
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
    public static class UploadProjectAvatarResponseSecurityRulesetsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseSecurityRulesetsAction value)
        {
            return value switch
            {
                UploadProjectAvatarResponseSecurityRulesetsAction.Allow => "allow",
                UploadProjectAvatarResponseSecurityRulesetsAction.Bypass => "bypass",
                UploadProjectAvatarResponseSecurityRulesetsAction.Challenge => "challenge",
                UploadProjectAvatarResponseSecurityRulesetsAction.Deny => "deny",
                UploadProjectAvatarResponseSecurityRulesetsAction.Log => "log",
                UploadProjectAvatarResponseSecurityRulesetsAction.RateLimit => "rate_limit",
                UploadProjectAvatarResponseSecurityRulesetsAction.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseSecurityRulesetsAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => UploadProjectAvatarResponseSecurityRulesetsAction.Allow,
                "bypass" => UploadProjectAvatarResponseSecurityRulesetsAction.Bypass,
                "challenge" => UploadProjectAvatarResponseSecurityRulesetsAction.Challenge,
                "deny" => UploadProjectAvatarResponseSecurityRulesetsAction.Deny,
                "log" => UploadProjectAvatarResponseSecurityRulesetsAction.Log,
                "rate_limit" => UploadProjectAvatarResponseSecurityRulesetsAction.RateLimit,
                "redirect" => UploadProjectAvatarResponseSecurityRulesetsAction.Redirect,
                _ => null,
            };
        }
    }
}
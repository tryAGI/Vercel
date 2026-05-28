
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseSecurityManagedRulesBotFilterAction
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
    public static class UploadProjectAvatarResponseSecurityManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseSecurityManagedRulesBotFilterAction value)
        {
            return value switch
            {
                UploadProjectAvatarResponseSecurityManagedRulesBotFilterAction.Challenge => "challenge",
                UploadProjectAvatarResponseSecurityManagedRulesBotFilterAction.Deny => "deny",
                UploadProjectAvatarResponseSecurityManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseSecurityManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UploadProjectAvatarResponseSecurityManagedRulesBotFilterAction.Challenge,
                "deny" => UploadProjectAvatarResponseSecurityManagedRulesBotFilterAction.Deny,
                "log" => UploadProjectAvatarResponseSecurityManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}
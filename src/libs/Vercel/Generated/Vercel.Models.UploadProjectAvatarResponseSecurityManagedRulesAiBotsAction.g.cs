
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseSecurityManagedRulesAiBotsAction
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
    public static class UploadProjectAvatarResponseSecurityManagedRulesAiBotsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseSecurityManagedRulesAiBotsAction value)
        {
            return value switch
            {
                UploadProjectAvatarResponseSecurityManagedRulesAiBotsAction.Challenge => "challenge",
                UploadProjectAvatarResponseSecurityManagedRulesAiBotsAction.Deny => "deny",
                UploadProjectAvatarResponseSecurityManagedRulesAiBotsAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseSecurityManagedRulesAiBotsAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UploadProjectAvatarResponseSecurityManagedRulesAiBotsAction.Challenge,
                "deny" => UploadProjectAvatarResponseSecurityManagedRulesAiBotsAction.Deny,
                "log" => UploadProjectAvatarResponseSecurityManagedRulesAiBotsAction.Log,
                _ => null,
            };
        }
    }
}
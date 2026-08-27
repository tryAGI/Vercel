
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UploadProjectAvatarResponseSecurityManagedRulesOwaspAction
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
    public static class UploadProjectAvatarResponseSecurityManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseSecurityManagedRulesOwaspAction value)
        {
            return value switch
            {
                UploadProjectAvatarResponseSecurityManagedRulesOwaspAction.Challenge => "challenge",
                UploadProjectAvatarResponseSecurityManagedRulesOwaspAction.Deny => "deny",
                UploadProjectAvatarResponseSecurityManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseSecurityManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UploadProjectAvatarResponseSecurityManagedRulesOwaspAction.Challenge,
                "deny" => UploadProjectAvatarResponseSecurityManagedRulesOwaspAction.Deny,
                "log" => UploadProjectAvatarResponseSecurityManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}
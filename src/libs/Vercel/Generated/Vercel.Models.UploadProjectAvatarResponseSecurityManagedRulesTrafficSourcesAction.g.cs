
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseSecurityManagedRulesTrafficSourcesAction
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
    public static class UploadProjectAvatarResponseSecurityManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseSecurityManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                UploadProjectAvatarResponseSecurityManagedRulesTrafficSourcesAction.Challenge => "challenge",
                UploadProjectAvatarResponseSecurityManagedRulesTrafficSourcesAction.Deny => "deny",
                UploadProjectAvatarResponseSecurityManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseSecurityManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UploadProjectAvatarResponseSecurityManagedRulesTrafficSourcesAction.Challenge,
                "deny" => UploadProjectAvatarResponseSecurityManagedRulesTrafficSourcesAction.Deny,
                "log" => UploadProjectAvatarResponseSecurityManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}
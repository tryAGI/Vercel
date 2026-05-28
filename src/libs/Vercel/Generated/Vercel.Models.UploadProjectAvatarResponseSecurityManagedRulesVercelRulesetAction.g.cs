
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseSecurityManagedRulesVercelRulesetAction
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
    public static class UploadProjectAvatarResponseSecurityManagedRulesVercelRulesetActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseSecurityManagedRulesVercelRulesetAction value)
        {
            return value switch
            {
                UploadProjectAvatarResponseSecurityManagedRulesVercelRulesetAction.Challenge => "challenge",
                UploadProjectAvatarResponseSecurityManagedRulesVercelRulesetAction.Deny => "deny",
                UploadProjectAvatarResponseSecurityManagedRulesVercelRulesetAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseSecurityManagedRulesVercelRulesetAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UploadProjectAvatarResponseSecurityManagedRulesVercelRulesetAction.Challenge,
                "deny" => UploadProjectAvatarResponseSecurityManagedRulesVercelRulesetAction.Deny,
                "log" => UploadProjectAvatarResponseSecurityManagedRulesVercelRulesetAction.Log,
                _ => null,
            };
        }
    }
}
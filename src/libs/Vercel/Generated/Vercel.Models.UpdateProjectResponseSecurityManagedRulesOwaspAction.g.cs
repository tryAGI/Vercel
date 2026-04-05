
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseSecurityManagedRulesOwaspAction
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
    public static class UpdateProjectResponseSecurityManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSecurityManagedRulesOwaspAction value)
        {
            return value switch
            {
                UpdateProjectResponseSecurityManagedRulesOwaspAction.Challenge => "challenge",
                UpdateProjectResponseSecurityManagedRulesOwaspAction.Deny => "deny",
                UpdateProjectResponseSecurityManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSecurityManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateProjectResponseSecurityManagedRulesOwaspAction.Challenge,
                "deny" => UpdateProjectResponseSecurityManagedRulesOwaspAction.Deny,
                "log" => UpdateProjectResponseSecurityManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}
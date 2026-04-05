
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseSecurityManagedRulesOwaspAction
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
    public static class GetProjectResponseSecurityManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSecurityManagedRulesOwaspAction value)
        {
            return value switch
            {
                GetProjectResponseSecurityManagedRulesOwaspAction.Challenge => "challenge",
                GetProjectResponseSecurityManagedRulesOwaspAction.Deny => "deny",
                GetProjectResponseSecurityManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSecurityManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectResponseSecurityManagedRulesOwaspAction.Challenge,
                "deny" => GetProjectResponseSecurityManagedRulesOwaspAction.Deny,
                "log" => GetProjectResponseSecurityManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}
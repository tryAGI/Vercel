
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseSecurityManagedRulesOwaspAction
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
    public static class CreateProjectResponseSecurityManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSecurityManagedRulesOwaspAction value)
        {
            return value switch
            {
                CreateProjectResponseSecurityManagedRulesOwaspAction.Challenge => "challenge",
                CreateProjectResponseSecurityManagedRulesOwaspAction.Deny => "deny",
                CreateProjectResponseSecurityManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSecurityManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateProjectResponseSecurityManagedRulesOwaspAction.Challenge,
                "deny" => CreateProjectResponseSecurityManagedRulesOwaspAction.Deny,
                "log" => CreateProjectResponseSecurityManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}
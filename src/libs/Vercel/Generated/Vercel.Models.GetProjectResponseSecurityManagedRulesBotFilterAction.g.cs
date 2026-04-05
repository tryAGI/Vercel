
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseSecurityManagedRulesBotFilterAction
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
    public static class GetProjectResponseSecurityManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSecurityManagedRulesBotFilterAction value)
        {
            return value switch
            {
                GetProjectResponseSecurityManagedRulesBotFilterAction.Challenge => "challenge",
                GetProjectResponseSecurityManagedRulesBotFilterAction.Deny => "deny",
                GetProjectResponseSecurityManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSecurityManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectResponseSecurityManagedRulesBotFilterAction.Challenge,
                "deny" => GetProjectResponseSecurityManagedRulesBotFilterAction.Deny,
                "log" => GetProjectResponseSecurityManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}
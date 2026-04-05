
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseSecurityManagedRulesBotFilterAction
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
    public static class CreateProjectResponseSecurityManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSecurityManagedRulesBotFilterAction value)
        {
            return value switch
            {
                CreateProjectResponseSecurityManagedRulesBotFilterAction.Challenge => "challenge",
                CreateProjectResponseSecurityManagedRulesBotFilterAction.Deny => "deny",
                CreateProjectResponseSecurityManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSecurityManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateProjectResponseSecurityManagedRulesBotFilterAction.Challenge,
                "deny" => CreateProjectResponseSecurityManagedRulesBotFilterAction.Deny,
                "log" => CreateProjectResponseSecurityManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}
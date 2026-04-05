
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseSecurityManagedRulesBotFilterAction
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
    public static class UpdateProjectResponseSecurityManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSecurityManagedRulesBotFilterAction value)
        {
            return value switch
            {
                UpdateProjectResponseSecurityManagedRulesBotFilterAction.Challenge => "challenge",
                UpdateProjectResponseSecurityManagedRulesBotFilterAction.Deny => "deny",
                UpdateProjectResponseSecurityManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSecurityManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateProjectResponseSecurityManagedRulesBotFilterAction.Challenge,
                "deny" => UpdateProjectResponseSecurityManagedRulesBotFilterAction.Deny,
                "log" => UpdateProjectResponseSecurityManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}
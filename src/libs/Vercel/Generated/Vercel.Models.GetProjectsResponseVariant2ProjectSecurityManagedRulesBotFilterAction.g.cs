
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectSecurityManagedRulesBotFilterAction
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
    public static class GetProjectsResponseVariant2ProjectSecurityManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectSecurityManagedRulesBotFilterAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectSecurityManagedRulesBotFilterAction.Challenge => "challenge",
                GetProjectsResponseVariant2ProjectSecurityManagedRulesBotFilterAction.Deny => "deny",
                GetProjectsResponseVariant2ProjectSecurityManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectSecurityManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant2ProjectSecurityManagedRulesBotFilterAction.Challenge,
                "deny" => GetProjectsResponseVariant2ProjectSecurityManagedRulesBotFilterAction.Deny,
                "log" => GetProjectsResponseVariant2ProjectSecurityManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}
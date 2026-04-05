
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemSecurityManagedRulesBotFilterAction
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
    public static class GetProjectsResponseVariant1ItemSecurityManagedRulesBotFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemSecurityManagedRulesBotFilterAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemSecurityManagedRulesBotFilterAction.Challenge => "challenge",
                GetProjectsResponseVariant1ItemSecurityManagedRulesBotFilterAction.Deny => "deny",
                GetProjectsResponseVariant1ItemSecurityManagedRulesBotFilterAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemSecurityManagedRulesBotFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetProjectsResponseVariant1ItemSecurityManagedRulesBotFilterAction.Challenge,
                "deny" => GetProjectsResponseVariant1ItemSecurityManagedRulesBotFilterAction.Deny,
                "log" => GetProjectsResponseVariant1ItemSecurityManagedRulesBotFilterAction.Log,
                _ => null,
            };
        }
    }
}
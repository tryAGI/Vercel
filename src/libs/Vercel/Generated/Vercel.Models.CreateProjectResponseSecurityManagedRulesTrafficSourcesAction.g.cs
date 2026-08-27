
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseSecurityManagedRulesTrafficSourcesAction
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
    public static class CreateProjectResponseSecurityManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSecurityManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                CreateProjectResponseSecurityManagedRulesTrafficSourcesAction.Challenge => "challenge",
                CreateProjectResponseSecurityManagedRulesTrafficSourcesAction.Deny => "deny",
                CreateProjectResponseSecurityManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSecurityManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => CreateProjectResponseSecurityManagedRulesTrafficSourcesAction.Challenge,
                "deny" => CreateProjectResponseSecurityManagedRulesTrafficSourcesAction.Deny,
                "log" => CreateProjectResponseSecurityManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}
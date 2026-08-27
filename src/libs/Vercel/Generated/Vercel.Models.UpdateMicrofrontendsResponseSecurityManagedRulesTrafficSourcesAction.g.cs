
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseSecurityManagedRulesTrafficSourcesAction
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
    public static class UpdateMicrofrontendsResponseSecurityManagedRulesTrafficSourcesActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseSecurityManagedRulesTrafficSourcesAction value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseSecurityManagedRulesTrafficSourcesAction.Challenge => "challenge",
                UpdateMicrofrontendsResponseSecurityManagedRulesTrafficSourcesAction.Deny => "deny",
                UpdateMicrofrontendsResponseSecurityManagedRulesTrafficSourcesAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseSecurityManagedRulesTrafficSourcesAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateMicrofrontendsResponseSecurityManagedRulesTrafficSourcesAction.Challenge,
                "deny" => UpdateMicrofrontendsResponseSecurityManagedRulesTrafficSourcesAction.Deny,
                "log" => UpdateMicrofrontendsResponseSecurityManagedRulesTrafficSourcesAction.Log,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSecurityFirewallConfigResponseDraftManagedRulesOwaspAction
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
    public static class GetSecurityFirewallConfigResponseDraftManagedRulesOwaspActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSecurityFirewallConfigResponseDraftManagedRulesOwaspAction value)
        {
            return value switch
            {
                GetSecurityFirewallConfigResponseDraftManagedRulesOwaspAction.Challenge => "challenge",
                GetSecurityFirewallConfigResponseDraftManagedRulesOwaspAction.Deny => "deny",
                GetSecurityFirewallConfigResponseDraftManagedRulesOwaspAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSecurityFirewallConfigResponseDraftManagedRulesOwaspAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GetSecurityFirewallConfigResponseDraftManagedRulesOwaspAction.Challenge,
                "deny" => GetSecurityFirewallConfigResponseDraftManagedRulesOwaspAction.Deny,
                "log" => GetSecurityFirewallConfigResponseDraftManagedRulesOwaspAction.Log,
                _ => null,
            };
        }
    }
}
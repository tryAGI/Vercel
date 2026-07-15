
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant1ValueActionMitigateAction
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
    public static class UpdateFirewallConfigRequestVariant1ValueActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant1ValueActionMitigateAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant1ValueActionMitigateAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant1ValueActionMitigateAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant1ValueActionMitigateAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant1ValueActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant1ValueActionMitigateAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant1ValueActionMitigateAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant1ValueActionMitigateAction.Log,
                _ => null,
            };
        }
    }
}
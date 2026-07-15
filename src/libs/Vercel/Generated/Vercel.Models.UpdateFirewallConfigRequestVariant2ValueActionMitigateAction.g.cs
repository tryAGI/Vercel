
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant2ValueActionMitigateAction
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
    public static class UpdateFirewallConfigRequestVariant2ValueActionMitigateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant2ValueActionMitigateAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant2ValueActionMitigateAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant2ValueActionMitigateAction.Log,
                _ => null,
            };
        }
    }
}
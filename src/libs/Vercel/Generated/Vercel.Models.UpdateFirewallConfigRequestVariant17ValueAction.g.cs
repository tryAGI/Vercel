
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant17ValueAction
    {
        /// <summary>
        ///
        /// </summary>
        Bypass,
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
    public static class UpdateFirewallConfigRequestVariant17ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant17ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant17ValueAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant17ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant17ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant17ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant17ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant17ValueAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant17ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant17ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant17ValueAction.Log,
                _ => null,
            };
        }
    }
}
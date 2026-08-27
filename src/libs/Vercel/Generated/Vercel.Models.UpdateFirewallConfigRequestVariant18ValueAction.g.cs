
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant18ValueAction
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
    public static class UpdateFirewallConfigRequestVariant18ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant18ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant18ValueAction.Bypass => "bypass",
                UpdateFirewallConfigRequestVariant18ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant18ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant18ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant18ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "bypass" => UpdateFirewallConfigRequestVariant18ValueAction.Bypass,
                "challenge" => UpdateFirewallConfigRequestVariant18ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant18ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant18ValueAction.Log,
                _ => null,
            };
        }
    }
}
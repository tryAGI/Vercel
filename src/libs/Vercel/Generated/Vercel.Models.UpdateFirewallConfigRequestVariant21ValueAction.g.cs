
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant21ValueAction
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
    public static class UpdateFirewallConfigRequestVariant21ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant21ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant21ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant21ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant21ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant21ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant21ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant21ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant21ValueAction.Log,
                _ => null,
            };
        }
    }
}
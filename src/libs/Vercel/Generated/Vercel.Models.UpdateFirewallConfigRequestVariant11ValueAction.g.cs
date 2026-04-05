
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant11ValueAction
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
    public static class UpdateFirewallConfigRequestVariant11ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant11ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant11ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant11ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant11ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant11ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant11ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant11ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant11ValueAction.Log,
                _ => null,
            };
        }
    }
}
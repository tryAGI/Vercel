
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant12ValueAction
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
    public static class UpdateFirewallConfigRequestVariant12ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant12ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant12ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant12ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant12ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant12ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant12ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant12ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant12ValueAction.Log,
                _ => null,
            };
        }
    }
}
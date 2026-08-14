
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant20ValueAction
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
    public static class UpdateFirewallConfigRequestVariant20ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant20ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant20ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant20ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant20ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant20ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant20ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant20ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant20ValueAction.Log,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant19ValueAction
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
    public static class UpdateFirewallConfigRequestVariant19ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant19ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant19ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant19ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant19ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant19ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => UpdateFirewallConfigRequestVariant19ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant19ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant19ValueAction.Log,
                _ => null,
            };
        }
    }
}
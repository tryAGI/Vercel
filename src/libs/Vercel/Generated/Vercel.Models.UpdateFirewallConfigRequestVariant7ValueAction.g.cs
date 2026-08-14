
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFirewallConfigRequestVariant7ValueAction
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
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
    public static class UpdateFirewallConfigRequestVariant7ValueActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFirewallConfigRequestVariant7ValueAction value)
        {
            return value switch
            {
                UpdateFirewallConfigRequestVariant7ValueAction.Allow => "allow",
                UpdateFirewallConfigRequestVariant7ValueAction.Challenge => "challenge",
                UpdateFirewallConfigRequestVariant7ValueAction.Deny => "deny",
                UpdateFirewallConfigRequestVariant7ValueAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFirewallConfigRequestVariant7ValueAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => UpdateFirewallConfigRequestVariant7ValueAction.Allow,
                "challenge" => UpdateFirewallConfigRequestVariant7ValueAction.Challenge,
                "deny" => UpdateFirewallConfigRequestVariant7ValueAction.Deny,
                "log" => UpdateFirewallConfigRequestVariant7ValueAction.Log,
                _ => null,
            };
        }
    }
}
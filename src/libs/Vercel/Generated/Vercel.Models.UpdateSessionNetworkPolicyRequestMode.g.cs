
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use "allow-all" to permit all outbound traffic. Use "deny-all" to block all outbound traffic. Use "custom" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum UpdateSessionNetworkPolicyRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        AllowAll,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        DefaultAllow,
        /// <summary>
        /// 
        /// </summary>
        DefaultDeny,
        /// <summary>
        /// 
        /// </summary>
        DenyAll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSessionNetworkPolicyRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSessionNetworkPolicyRequestMode value)
        {
            return value switch
            {
                UpdateSessionNetworkPolicyRequestMode.AllowAll => "allow-all",
                UpdateSessionNetworkPolicyRequestMode.Custom => "custom",
                UpdateSessionNetworkPolicyRequestMode.DefaultAllow => "default-allow",
                UpdateSessionNetworkPolicyRequestMode.DefaultDeny => "default-deny",
                UpdateSessionNetworkPolicyRequestMode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSessionNetworkPolicyRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => UpdateSessionNetworkPolicyRequestMode.AllowAll,
                "custom" => UpdateSessionNetworkPolicyRequestMode.Custom,
                "default-allow" => UpdateSessionNetworkPolicyRequestMode.DefaultAllow,
                "default-deny" => UpdateSessionNetworkPolicyRequestMode.DefaultDeny,
                "deny-all" => UpdateSessionNetworkPolicyRequestMode.DenyAll,
                _ => null,
            };
        }
    }
}
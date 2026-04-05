
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum UpdateNetworkPolicyRequestMode
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
    public static class UpdateNetworkPolicyRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateNetworkPolicyRequestMode value)
        {
            return value switch
            {
                UpdateNetworkPolicyRequestMode.AllowAll => "allow-all",
                UpdateNetworkPolicyRequestMode.Custom => "custom",
                UpdateNetworkPolicyRequestMode.DefaultAllow => "default-allow",
                UpdateNetworkPolicyRequestMode.DefaultDeny => "default-deny",
                UpdateNetworkPolicyRequestMode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateNetworkPolicyRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => UpdateNetworkPolicyRequestMode.AllowAll,
                "custom" => UpdateNetworkPolicyRequestMode.Custom,
                "default-allow" => UpdateNetworkPolicyRequestMode.DefaultAllow,
                "default-deny" => UpdateNetworkPolicyRequestMode.DefaultDeny,
                "deny-all" => UpdateNetworkPolicyRequestMode.DenyAll,
                _ => null,
            };
        }
    }
}
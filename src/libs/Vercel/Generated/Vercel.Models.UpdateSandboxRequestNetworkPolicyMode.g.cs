
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum UpdateSandboxRequestNetworkPolicyMode
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
    public static class UpdateSandboxRequestNetworkPolicyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSandboxRequestNetworkPolicyMode value)
        {
            return value switch
            {
                UpdateSandboxRequestNetworkPolicyMode.AllowAll => "allow-all",
                UpdateSandboxRequestNetworkPolicyMode.Custom => "custom",
                UpdateSandboxRequestNetworkPolicyMode.DefaultAllow => "default-allow",
                UpdateSandboxRequestNetworkPolicyMode.DefaultDeny => "default-deny",
                UpdateSandboxRequestNetworkPolicyMode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSandboxRequestNetworkPolicyMode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => UpdateSandboxRequestNetworkPolicyMode.AllowAll,
                "custom" => UpdateSandboxRequestNetworkPolicyMode.Custom,
                "default-allow" => UpdateSandboxRequestNetworkPolicyMode.DefaultAllow,
                "default-deny" => UpdateSandboxRequestNetworkPolicyMode.DefaultDeny,
                "deny-all" => UpdateSandboxRequestNetworkPolicyMode.DenyAll,
                _ => null,
            };
        }
    }
}
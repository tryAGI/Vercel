
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum UpdateSandboxRequestNetworkPolicyVariant1Mode
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
    public static class UpdateSandboxRequestNetworkPolicyVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSandboxRequestNetworkPolicyVariant1Mode value)
        {
            return value switch
            {
                UpdateSandboxRequestNetworkPolicyVariant1Mode.AllowAll => "allow-all",
                UpdateSandboxRequestNetworkPolicyVariant1Mode.Custom => "custom",
                UpdateSandboxRequestNetworkPolicyVariant1Mode.DefaultAllow => "default-allow",
                UpdateSandboxRequestNetworkPolicyVariant1Mode.DefaultDeny => "default-deny",
                UpdateSandboxRequestNetworkPolicyVariant1Mode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSandboxRequestNetworkPolicyVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => UpdateSandboxRequestNetworkPolicyVariant1Mode.AllowAll,
                "custom" => UpdateSandboxRequestNetworkPolicyVariant1Mode.Custom,
                "default-allow" => UpdateSandboxRequestNetworkPolicyVariant1Mode.DefaultAllow,
                "default-deny" => UpdateSandboxRequestNetworkPolicyVariant1Mode.DefaultDeny,
                "deny-all" => UpdateSandboxRequestNetworkPolicyVariant1Mode.DenyAll,
                _ => null,
            };
        }
    }
}
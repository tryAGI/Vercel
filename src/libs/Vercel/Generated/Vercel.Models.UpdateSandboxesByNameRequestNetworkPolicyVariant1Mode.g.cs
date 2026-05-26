
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode
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
    public static class UpdateSandboxesByNameRequestNetworkPolicyVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode value)
        {
            return value switch
            {
                UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode.AllowAll => "allow-all",
                UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode.Custom => "custom",
                UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode.DefaultAllow => "default-allow",
                UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode.DefaultDeny => "default-deny",
                UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode.AllowAll,
                "custom" => UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode.Custom,
                "default-allow" => UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode.DefaultAllow,
                "default-deny" => UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode.DefaultDeny,
                "deny-all" => UpdateSandboxesByNameRequestNetworkPolicyVariant1Mode.DenyAll,
                _ => null,
            };
        }
    }
}
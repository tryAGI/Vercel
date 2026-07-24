
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode
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
    public static class CreateSandboxesByNameForkRequestNetworkPolicyVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode value)
        {
            return value switch
            {
                CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode.AllowAll => "allow-all",
                CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode.Custom => "custom",
                CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode.DefaultAllow => "default-allow",
                CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode.DefaultDeny => "default-deny",
                CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode.AllowAll,
                "custom" => CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode.Custom,
                "default-allow" => CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode.DefaultAllow,
                "default-deny" => CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode.DefaultDeny,
                "deny-all" => CreateSandboxesByNameForkRequestNetworkPolicyVariant1Mode.DenyAll,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum CreateSandboxesRequestNetworkPolicyVariant1Mode
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
    public static class CreateSandboxesRequestNetworkPolicyVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesRequestNetworkPolicyVariant1Mode value)
        {
            return value switch
            {
                CreateSandboxesRequestNetworkPolicyVariant1Mode.AllowAll => "allow-all",
                CreateSandboxesRequestNetworkPolicyVariant1Mode.Custom => "custom",
                CreateSandboxesRequestNetworkPolicyVariant1Mode.DefaultAllow => "default-allow",
                CreateSandboxesRequestNetworkPolicyVariant1Mode.DefaultDeny => "default-deny",
                CreateSandboxesRequestNetworkPolicyVariant1Mode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesRequestNetworkPolicyVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => CreateSandboxesRequestNetworkPolicyVariant1Mode.AllowAll,
                "custom" => CreateSandboxesRequestNetworkPolicyVariant1Mode.Custom,
                "default-allow" => CreateSandboxesRequestNetworkPolicyVariant1Mode.DefaultAllow,
                "default-deny" => CreateSandboxesRequestNetworkPolicyVariant1Mode.DefaultDeny,
                "deny-all" => CreateSandboxesRequestNetworkPolicyVariant1Mode.DenyAll,
                _ => null,
            };
        }
    }
}
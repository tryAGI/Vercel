
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum CreateSandboxesV4RequestNetworkPolicyVariant1Mode
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
    public static class CreateSandboxesV4RequestNetworkPolicyVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV4RequestNetworkPolicyVariant1Mode value)
        {
            return value switch
            {
                CreateSandboxesV4RequestNetworkPolicyVariant1Mode.AllowAll => "allow-all",
                CreateSandboxesV4RequestNetworkPolicyVariant1Mode.Custom => "custom",
                CreateSandboxesV4RequestNetworkPolicyVariant1Mode.DefaultAllow => "default-allow",
                CreateSandboxesV4RequestNetworkPolicyVariant1Mode.DefaultDeny => "default-deny",
                CreateSandboxesV4RequestNetworkPolicyVariant1Mode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesV4RequestNetworkPolicyVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => CreateSandboxesV4RequestNetworkPolicyVariant1Mode.AllowAll,
                "custom" => CreateSandboxesV4RequestNetworkPolicyVariant1Mode.Custom,
                "default-allow" => CreateSandboxesV4RequestNetworkPolicyVariant1Mode.DefaultAllow,
                "default-deny" => CreateSandboxesV4RequestNetworkPolicyVariant1Mode.DefaultDeny,
                "deny-all" => CreateSandboxesV4RequestNetworkPolicyVariant1Mode.DenyAll,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum CreateSandboxesV3RequestNetworkPolicyVariant1Mode
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
    public static class CreateSandboxesV3RequestNetworkPolicyVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV3RequestNetworkPolicyVariant1Mode value)
        {
            return value switch
            {
                CreateSandboxesV3RequestNetworkPolicyVariant1Mode.AllowAll => "allow-all",
                CreateSandboxesV3RequestNetworkPolicyVariant1Mode.Custom => "custom",
                CreateSandboxesV3RequestNetworkPolicyVariant1Mode.DefaultAllow => "default-allow",
                CreateSandboxesV3RequestNetworkPolicyVariant1Mode.DefaultDeny => "default-deny",
                CreateSandboxesV3RequestNetworkPolicyVariant1Mode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesV3RequestNetworkPolicyVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => CreateSandboxesV3RequestNetworkPolicyVariant1Mode.AllowAll,
                "custom" => CreateSandboxesV3RequestNetworkPolicyVariant1Mode.Custom,
                "default-allow" => CreateSandboxesV3RequestNetworkPolicyVariant1Mode.DefaultAllow,
                "default-deny" => CreateSandboxesV3RequestNetworkPolicyVariant1Mode.DefaultDeny,
                "deny-all" => CreateSandboxesV3RequestNetworkPolicyVariant1Mode.DenyAll,
                _ => null,
            };
        }
    }
}
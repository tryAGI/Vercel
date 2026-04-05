
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum CreateSandboxesRequestNetworkPolicyMode
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
    public static class CreateSandboxesRequestNetworkPolicyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesRequestNetworkPolicyMode value)
        {
            return value switch
            {
                CreateSandboxesRequestNetworkPolicyMode.AllowAll => "allow-all",
                CreateSandboxesRequestNetworkPolicyMode.Custom => "custom",
                CreateSandboxesRequestNetworkPolicyMode.DefaultAllow => "default-allow",
                CreateSandboxesRequestNetworkPolicyMode.DefaultDeny => "default-deny",
                CreateSandboxesRequestNetworkPolicyMode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesRequestNetworkPolicyMode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => CreateSandboxesRequestNetworkPolicyMode.AllowAll,
                "custom" => CreateSandboxesRequestNetworkPolicyMode.Custom,
                "default-allow" => CreateSandboxesRequestNetworkPolicyMode.DefaultAllow,
                "default-deny" => CreateSandboxesRequestNetworkPolicyMode.DefaultDeny,
                "deny-all" => CreateSandboxesRequestNetworkPolicyMode.DenyAll,
                _ => null,
            };
        }
    }
}
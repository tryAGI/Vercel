
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum CreateSandboxRequestNetworkPolicyMode
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
    public static class CreateSandboxRequestNetworkPolicyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxRequestNetworkPolicyMode value)
        {
            return value switch
            {
                CreateSandboxRequestNetworkPolicyMode.AllowAll => "allow-all",
                CreateSandboxRequestNetworkPolicyMode.Custom => "custom",
                CreateSandboxRequestNetworkPolicyMode.DefaultAllow => "default-allow",
                CreateSandboxRequestNetworkPolicyMode.DefaultDeny => "default-deny",
                CreateSandboxRequestNetworkPolicyMode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxRequestNetworkPolicyMode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => CreateSandboxRequestNetworkPolicyMode.AllowAll,
                "custom" => CreateSandboxRequestNetworkPolicyMode.Custom,
                "default-allow" => CreateSandboxRequestNetworkPolicyMode.DefaultAllow,
                "default-deny" => CreateSandboxRequestNetworkPolicyMode.DefaultDeny,
                "deny-all" => CreateSandboxRequestNetworkPolicyMode.DenyAll,
                _ => null,
            };
        }
    }
}
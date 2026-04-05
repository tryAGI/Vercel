
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum NamedSandboxNetworkPolicyMode
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
    public static class NamedSandboxNetworkPolicyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamedSandboxNetworkPolicyMode value)
        {
            return value switch
            {
                NamedSandboxNetworkPolicyMode.AllowAll => "allow-all",
                NamedSandboxNetworkPolicyMode.Custom => "custom",
                NamedSandboxNetworkPolicyMode.DefaultAllow => "default-allow",
                NamedSandboxNetworkPolicyMode.DefaultDeny => "default-deny",
                NamedSandboxNetworkPolicyMode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamedSandboxNetworkPolicyMode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => NamedSandboxNetworkPolicyMode.AllowAll,
                "custom" => NamedSandboxNetworkPolicyMode.Custom,
                "default-allow" => NamedSandboxNetworkPolicyMode.DefaultAllow,
                "default-deny" => NamedSandboxNetworkPolicyMode.DefaultDeny,
                "deny-all" => NamedSandboxNetworkPolicyMode.DenyAll,
                _ => null,
            };
        }
    }
}
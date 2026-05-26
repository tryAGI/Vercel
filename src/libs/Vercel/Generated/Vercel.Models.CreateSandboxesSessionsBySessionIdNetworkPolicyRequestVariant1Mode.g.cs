
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode
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
    public static class CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode value)
        {
            return value switch
            {
                CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode.AllowAll => "allow-all",
                CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode.Custom => "custom",
                CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode.DefaultAllow => "default-allow",
                CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode.DefaultDeny => "default-deny",
                CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode.AllowAll,
                "custom" => CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode.Custom,
                "default-allow" => CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode.DefaultAllow,
                "default-deny" => CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode.DefaultDeny,
                "deny-all" => CreateSandboxesSessionsBySessionIdNetworkPolicyRequestVariant1Mode.DenyAll,
                _ => null,
            };
        }
    }
}
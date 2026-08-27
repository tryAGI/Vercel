
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum UpdateSessionNetworkPolicyRequestVariant1Mode
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
    public static class UpdateSessionNetworkPolicyRequestVariant1ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSessionNetworkPolicyRequestVariant1Mode value)
        {
            return value switch
            {
                UpdateSessionNetworkPolicyRequestVariant1Mode.AllowAll => "allow-all",
                UpdateSessionNetworkPolicyRequestVariant1Mode.Custom => "custom",
                UpdateSessionNetworkPolicyRequestVariant1Mode.DefaultAllow => "default-allow",
                UpdateSessionNetworkPolicyRequestVariant1Mode.DefaultDeny => "default-deny",
                UpdateSessionNetworkPolicyRequestVariant1Mode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSessionNetworkPolicyRequestVariant1Mode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => UpdateSessionNetworkPolicyRequestVariant1Mode.AllowAll,
                "custom" => UpdateSessionNetworkPolicyRequestVariant1Mode.Custom,
                "default-allow" => UpdateSessionNetworkPolicyRequestVariant1Mode.DefaultAllow,
                "default-deny" => UpdateSessionNetworkPolicyRequestVariant1Mode.DefaultDeny,
                "deny-all" => UpdateSessionNetworkPolicyRequestVariant1Mode.DenyAll,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network policy mode. - 'allow-all': All traffic is allowed. - 'deny-all': All traffic is blocked. - 'custom': Traffic is controlled by explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum SandboxNetworkPolicyMode
    {
        /// <summary>
        /// All traffic is allowed. - 'deny-all': All traffic is blocked. - 'custom': Traffic is controlled by explicit allow/deny rules.
        /// </summary>
        AllowAll,
        /// <summary>
        /// All traffic is allowed. - 'deny-all': All traffic is blocked. - 'custom': Traffic is controlled by explicit allow/deny rules.
        /// </summary>
        Custom,
        /// <summary>
        /// All traffic is allowed. - 'deny-all': All traffic is blocked. - 'custom': Traffic is controlled by explicit allow/deny rules.
        /// </summary>
        DenyAll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxNetworkPolicyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxNetworkPolicyMode value)
        {
            return value switch
            {
                SandboxNetworkPolicyMode.AllowAll => "allow-all",
                SandboxNetworkPolicyMode.Custom => "custom",
                SandboxNetworkPolicyMode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxNetworkPolicyMode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => SandboxNetworkPolicyMode.AllowAll,
                "custom" => SandboxNetworkPolicyMode.Custom,
                "deny-all" => SandboxNetworkPolicyMode.DenyAll,
                _ => null,
            };
        }
    }
}
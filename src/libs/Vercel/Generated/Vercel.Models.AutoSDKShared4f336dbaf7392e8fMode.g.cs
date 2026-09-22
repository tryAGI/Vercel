
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The network access policy mode. Use \"allow-all\" to permit all outbound traffic. Use \"deny-all\" to block all outbound traffic. Use \"custom\" to specify explicit allow/deny rules.<br/>
    /// Example: custom
    /// </summary>
    public enum AutoSDKShared4f336dbaf7392e8fMode
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
    public static class AutoSDKShared4f336dbaf7392e8fModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4f336dbaf7392e8fMode value)
        {
            return value switch
            {
                AutoSDKShared4f336dbaf7392e8fMode.AllowAll => "allow-all",
                AutoSDKShared4f336dbaf7392e8fMode.Custom => "custom",
                AutoSDKShared4f336dbaf7392e8fMode.DefaultAllow => "default-allow",
                AutoSDKShared4f336dbaf7392e8fMode.DefaultDeny => "default-deny",
                AutoSDKShared4f336dbaf7392e8fMode.DenyAll => "deny-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4f336dbaf7392e8fMode? ToEnum(string value)
        {
            return value switch
            {
                "allow-all" => AutoSDKShared4f336dbaf7392e8fMode.AllowAll,
                "custom" => AutoSDKShared4f336dbaf7392e8fMode.Custom,
                "default-allow" => AutoSDKShared4f336dbaf7392e8fMode.DefaultAllow,
                "default-deny" => AutoSDKShared4f336dbaf7392e8fMode.DefaultDeny,
                "deny-all" => AutoSDKShared4f336dbaf7392e8fMode.DenyAll,
                _ => null,
            };
        }
    }
}
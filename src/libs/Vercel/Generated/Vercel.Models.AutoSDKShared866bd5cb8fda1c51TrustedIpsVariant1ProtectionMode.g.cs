
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared866bd5cb8fda1c51TrustedIpsVariant1ProtectionMode
    {
        /// <summary>
        ///
        /// </summary>
        Additional,
        /// <summary>
        ///
        /// </summary>
        Exclusive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared866bd5cb8fda1c51TrustedIpsVariant1ProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared866bd5cb8fda1c51TrustedIpsVariant1ProtectionMode value)
        {
            return value switch
            {
                AutoSDKShared866bd5cb8fda1c51TrustedIpsVariant1ProtectionMode.Additional => "additional",
                AutoSDKShared866bd5cb8fda1c51TrustedIpsVariant1ProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared866bd5cb8fda1c51TrustedIpsVariant1ProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => AutoSDKShared866bd5cb8fda1c51TrustedIpsVariant1ProtectionMode.Additional,
                "exclusive" => AutoSDKShared866bd5cb8fda1c51TrustedIpsVariant1ProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}
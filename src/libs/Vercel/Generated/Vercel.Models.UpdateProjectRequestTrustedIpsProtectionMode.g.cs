
#nullable enable

namespace Vercel
{
    /// <summary>
    /// exclusive: ip match is enough to bypass deployment protection (regardless of other settings). additional: ip must match + any other protection should be also provided (password, vercel auth, shareable link, automation bypass header, automation bypass query param)
    /// </summary>
    public enum UpdateProjectRequestTrustedIpsProtectionMode
    {
        /// <summary>
        /// ip match is enough to bypass deployment protection (regardless of other settings). additional: ip must match + any other protection should be also provided (password, vercel auth, shareable link, automation bypass header, automation bypass query param)
        /// </summary>
        Additional,
        /// <summary>
        /// ip match is enough to bypass deployment protection (regardless of other settings). additional: ip must match + any other protection should be also provided (password, vercel auth, shareable link, automation bypass header, automation bypass query param)
        /// </summary>
        Exclusive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestTrustedIpsProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestTrustedIpsProtectionMode value)
        {
            return value switch
            {
                UpdateProjectRequestTrustedIpsProtectionMode.Additional => "additional",
                UpdateProjectRequestTrustedIpsProtectionMode.Exclusive => "exclusive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestTrustedIpsProtectionMode? ToEnum(string value)
        {
            return value switch
            {
                "additional" => UpdateProjectRequestTrustedIpsProtectionMode.Additional,
                "exclusive" => UpdateProjectRequestTrustedIpsProtectionMode.Exclusive,
                _ => null,
            };
        }
    }
}
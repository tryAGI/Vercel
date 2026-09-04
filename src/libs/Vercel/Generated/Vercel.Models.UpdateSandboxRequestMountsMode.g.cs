
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Mount the drive read-only or read-write.<br/>
    /// Default Value: read-write
    /// </summary>
    public enum UpdateSandboxRequestMountsMode
    {
        /// <summary>
        ///
        /// </summary>
        ReadOnly,
        /// <summary>
        ///
        /// </summary>
        ReadWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSandboxRequestMountsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSandboxRequestMountsMode value)
        {
            return value switch
            {
                UpdateSandboxRequestMountsMode.ReadOnly => "read-only",
                UpdateSandboxRequestMountsMode.ReadWrite => "read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSandboxRequestMountsMode? ToEnum(string value)
        {
            return value switch
            {
                "read-only" => UpdateSandboxRequestMountsMode.ReadOnly,
                "read-write" => UpdateSandboxRequestMountsMode.ReadWrite,
                _ => null,
            };
        }
    }
}
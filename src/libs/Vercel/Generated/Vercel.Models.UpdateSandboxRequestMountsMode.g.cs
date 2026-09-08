
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Mount the drive as read-write, or as a read-only snapshot. One writer is permitted at a time.<br/>
    /// Default Value: read-write
    /// </summary>
    public enum UpdateSandboxRequestMountsMode
    {
        /// <summary>
        ///
        /// </summary>
        ReadWrite,
        /// <summary>
        ///
        /// </summary>
        Snapshot,
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
                UpdateSandboxRequestMountsMode.ReadWrite => "read-write",
                UpdateSandboxRequestMountsMode.Snapshot => "snapshot",
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
                "read-write" => UpdateSandboxRequestMountsMode.ReadWrite,
                "snapshot" => UpdateSandboxRequestMountsMode.Snapshot,
                _ => null,
            };
        }
    }
}
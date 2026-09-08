
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Mount the drive as read-write, or as a read-only snapshot. One writer is permitted at a time.<br/>
    /// Default Value: read-write
    /// </summary>
    public enum CreateSandboxesV4RequestMountsMode
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
    public static class CreateSandboxesV4RequestMountsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV4RequestMountsMode value)
        {
            return value switch
            {
                CreateSandboxesV4RequestMountsMode.ReadWrite => "read-write",
                CreateSandboxesV4RequestMountsMode.Snapshot => "snapshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesV4RequestMountsMode? ToEnum(string value)
        {
            return value switch
            {
                "read-write" => CreateSandboxesV4RequestMountsMode.ReadWrite,
                "snapshot" => CreateSandboxesV4RequestMountsMode.Snapshot,
                _ => null,
            };
        }
    }
}
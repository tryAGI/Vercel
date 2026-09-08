
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Mount the drive as read-write, or as a read-only snapshot. One writer is permitted at a time.<br/>
    /// Default Value: read-write
    /// </summary>
    public enum CreateSandboxesV3RequestMountsMode
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
    public static class CreateSandboxesV3RequestMountsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV3RequestMountsMode value)
        {
            return value switch
            {
                CreateSandboxesV3RequestMountsMode.ReadWrite => "read-write",
                CreateSandboxesV3RequestMountsMode.Snapshot => "snapshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesV3RequestMountsMode? ToEnum(string value)
        {
            return value switch
            {
                "read-write" => CreateSandboxesV3RequestMountsMode.ReadWrite,
                "snapshot" => CreateSandboxesV3RequestMountsMode.Snapshot,
                _ => null,
            };
        }
    }
}
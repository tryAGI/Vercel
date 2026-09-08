
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Mount the drive as read-write, or as a read-only snapshot. One writer is permitted at a time.<br/>
    /// Default Value: read-write
    /// </summary>
    public enum CreateSandboxesV2RequestMountsMode
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
    public static class CreateSandboxesV2RequestMountsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV2RequestMountsMode value)
        {
            return value switch
            {
                CreateSandboxesV2RequestMountsMode.ReadWrite => "read-write",
                CreateSandboxesV2RequestMountsMode.Snapshot => "snapshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesV2RequestMountsMode? ToEnum(string value)
        {
            return value switch
            {
                "read-write" => CreateSandboxesV2RequestMountsMode.ReadWrite,
                "snapshot" => CreateSandboxesV2RequestMountsMode.Snapshot,
                _ => null,
            };
        }
    }
}
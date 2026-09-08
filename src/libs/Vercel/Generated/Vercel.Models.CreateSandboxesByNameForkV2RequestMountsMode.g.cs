
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Mount the drive as read-write, or as a read-only snapshot. One writer is permitted at a time.<br/>
    /// Default Value: read-write
    /// </summary>
    public enum CreateSandboxesByNameForkV2RequestMountsMode
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
    public static class CreateSandboxesByNameForkV2RequestMountsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesByNameForkV2RequestMountsMode value)
        {
            return value switch
            {
                CreateSandboxesByNameForkV2RequestMountsMode.ReadWrite => "read-write",
                CreateSandboxesByNameForkV2RequestMountsMode.Snapshot => "snapshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesByNameForkV2RequestMountsMode? ToEnum(string value)
        {
            return value switch
            {
                "read-write" => CreateSandboxesByNameForkV2RequestMountsMode.ReadWrite,
                "snapshot" => CreateSandboxesByNameForkV2RequestMountsMode.Snapshot,
                _ => null,
            };
        }
    }
}
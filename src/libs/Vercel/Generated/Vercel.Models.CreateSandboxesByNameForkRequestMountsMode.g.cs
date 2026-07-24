
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Mount the drive read-only or read-write.<br/>
    /// Default Value: read-write
    /// </summary>
    public enum CreateSandboxesByNameForkRequestMountsMode
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
    public static class CreateSandboxesByNameForkRequestMountsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesByNameForkRequestMountsMode value)
        {
            return value switch
            {
                CreateSandboxesByNameForkRequestMountsMode.ReadOnly => "read-only",
                CreateSandboxesByNameForkRequestMountsMode.ReadWrite => "read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesByNameForkRequestMountsMode? ToEnum(string value)
        {
            return value switch
            {
                "read-only" => CreateSandboxesByNameForkRequestMountsMode.ReadOnly,
                "read-write" => CreateSandboxesByNameForkRequestMountsMode.ReadWrite,
                _ => null,
            };
        }
    }
}
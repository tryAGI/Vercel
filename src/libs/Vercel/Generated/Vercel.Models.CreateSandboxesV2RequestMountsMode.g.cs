
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Mount the drive read-only or read-write.<br/>
    /// Default Value: read-write
    /// </summary>
    public enum CreateSandboxesV2RequestMountsMode
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
    public static class CreateSandboxesV2RequestMountsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesV2RequestMountsMode value)
        {
            return value switch
            {
                CreateSandboxesV2RequestMountsMode.ReadOnly => "read-only",
                CreateSandboxesV2RequestMountsMode.ReadWrite => "read-write",
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
                "read-only" => CreateSandboxesV2RequestMountsMode.ReadOnly,
                "read-write" => CreateSandboxesV2RequestMountsMode.ReadWrite,
                _ => null,
            };
        }
    }
}
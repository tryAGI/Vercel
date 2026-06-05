
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Mount the drive read-only or read-write.<br/>
    /// Default Value: read-write
    /// </summary>
    public enum CreateSandboxesRequestMountsMode
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
    public static class CreateSandboxesRequestMountsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSandboxesRequestMountsMode value)
        {
            return value switch
            {
                CreateSandboxesRequestMountsMode.ReadOnly => "read-only",
                CreateSandboxesRequestMountsMode.ReadWrite => "read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSandboxesRequestMountsMode? ToEnum(string value)
        {
            return value switch
            {
                "read-only" => CreateSandboxesRequestMountsMode.ReadOnly,
                "read-write" => CreateSandboxesRequestMountsMode.ReadWrite,
                _ => null,
            };
        }
    }
}
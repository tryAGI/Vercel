
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum NamedSandboxMountsMode
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
    public static class NamedSandboxMountsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamedSandboxMountsMode value)
        {
            return value switch
            {
                NamedSandboxMountsMode.ReadOnly => "read-only",
                NamedSandboxMountsMode.ReadWrite => "read-write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamedSandboxMountsMode? ToEnum(string value)
        {
            return value switch
            {
                "read-only" => NamedSandboxMountsMode.ReadOnly,
                "read-write" => NamedSandboxMountsMode.ReadWrite,
                _ => null,
            };
        }
    }
}
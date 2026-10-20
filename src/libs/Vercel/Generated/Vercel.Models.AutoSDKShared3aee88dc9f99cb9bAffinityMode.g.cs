
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3aee88dc9f99cb9bAffinityMode
    {
        /// <summary>
        ///
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared3aee88dc9f99cb9bAffinityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3aee88dc9f99cb9bAffinityMode value)
        {
            return value switch
            {
                AutoSDKShared3aee88dc9f99cb9bAffinityMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3aee88dc9f99cb9bAffinityMode? ToEnum(string value)
        {
            return value switch
            {
                "strict" => AutoSDKShared3aee88dc9f99cb9bAffinityMode.Strict,
                _ => null,
            };
        }
    }
}
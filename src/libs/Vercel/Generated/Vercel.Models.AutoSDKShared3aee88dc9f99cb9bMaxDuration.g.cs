
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3aee88dc9f99cb9bMaxDuration
    {
        /// <summary>
        ///
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared3aee88dc9f99cb9bMaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3aee88dc9f99cb9bMaxDuration value)
        {
            return value switch
            {
                AutoSDKShared3aee88dc9f99cb9bMaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3aee88dc9f99cb9bMaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => AutoSDKShared3aee88dc9f99cb9bMaxDuration.Max,
                _ => null,
            };
        }
    }
}
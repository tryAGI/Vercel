
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedafa4bcd6bd044b8bAffinityMode
    {
        /// <summary>
        ///
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedafa4bcd6bd044b8bAffinityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedafa4bcd6bd044b8bAffinityMode value)
        {
            return value switch
            {
                AutoSDKSharedafa4bcd6bd044b8bAffinityMode.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedafa4bcd6bd044b8bAffinityMode? ToEnum(string value)
        {
            return value switch
            {
                "strict" => AutoSDKSharedafa4bcd6bd044b8bAffinityMode.Strict,
                _ => null,
            };
        }
    }
}
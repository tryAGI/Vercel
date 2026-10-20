
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedafa4bcd6bd044b8bMaxDuration
    {
        /// <summary>
        ///
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedafa4bcd6bd044b8bMaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedafa4bcd6bd044b8bMaxDuration value)
        {
            return value switch
            {
                AutoSDKSharedafa4bcd6bd044b8bMaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedafa4bcd6bd044b8bMaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => AutoSDKSharedafa4bcd6bd044b8bMaxDuration.Max,
                _ => null,
            };
        }
    }
}
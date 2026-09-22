
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5f7d6053e0f466daMaxDuration
    {
        /// <summary>
        ///
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared5f7d6053e0f466daMaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5f7d6053e0f466daMaxDuration value)
        {
            return value switch
            {
                AutoSDKShared5f7d6053e0f466daMaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5f7d6053e0f466daMaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => AutoSDKShared5f7d6053e0f466daMaxDuration.Max,
                _ => null,
            };
        }
    }
}
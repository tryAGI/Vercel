
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7882ff81487eef12MaxDuration
    {
        /// <summary>
        ///
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared7882ff81487eef12MaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7882ff81487eef12MaxDuration value)
        {
            return value switch
            {
                AutoSDKShared7882ff81487eef12MaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7882ff81487eef12MaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => AutoSDKShared7882ff81487eef12MaxDuration.Max,
                _ => null,
            };
        }
    }
}
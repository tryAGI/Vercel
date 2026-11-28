
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9deb058651e8aec8MaxDuration
    {
        /// <summary>
        ///
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9deb058651e8aec8MaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9deb058651e8aec8MaxDuration value)
        {
            return value switch
            {
                AutoSDKShared9deb058651e8aec8MaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9deb058651e8aec8MaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => AutoSDKShared9deb058651e8aec8MaxDuration.Max,
                _ => null,
            };
        }
    }
}
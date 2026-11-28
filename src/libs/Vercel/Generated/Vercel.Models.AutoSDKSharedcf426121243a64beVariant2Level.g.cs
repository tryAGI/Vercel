
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcf426121243a64beVariant2Level
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedcf426121243a64beVariant2LevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcf426121243a64beVariant2Level value)
        {
            return value switch
            {
                AutoSDKSharedcf426121243a64beVariant2Level.Error => "error",
                AutoSDKSharedcf426121243a64beVariant2Level.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcf426121243a64beVariant2Level? ToEnum(string value)
        {
            return value switch
            {
                "error" => AutoSDKSharedcf426121243a64beVariant2Level.Error,
                "warning" => AutoSDKSharedcf426121243a64beVariant2Level.Warning,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbd3f01cc8f6abd3dVariant2Level
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
    public static class AutoSDKSharedbd3f01cc8f6abd3dVariant2LevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbd3f01cc8f6abd3dVariant2Level value)
        {
            return value switch
            {
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Level.Error => "error",
                AutoSDKSharedbd3f01cc8f6abd3dVariant2Level.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbd3f01cc8f6abd3dVariant2Level? ToEnum(string value)
        {
            return value switch
            {
                "error" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Level.Error,
                "warning" => AutoSDKSharedbd3f01cc8f6abd3dVariant2Level.Warning,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedcf8b2aad6990cb5aOrigin
    {
        /// <summary>
        ///
        /// </summary>
        External,
        /// <summary>
        ///
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedcf8b2aad6990cb5aOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedcf8b2aad6990cb5aOrigin value)
        {
            return value switch
            {
                AutoSDKSharedcf8b2aad6990cb5aOrigin.External => "external",
                AutoSDKSharedcf8b2aad6990cb5aOrigin.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedcf8b2aad6990cb5aOrigin? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKSharedcf8b2aad6990cb5aOrigin.External,
                "vercel" => AutoSDKSharedcf8b2aad6990cb5aOrigin.Vercel,
                _ => null,
            };
        }
    }
}
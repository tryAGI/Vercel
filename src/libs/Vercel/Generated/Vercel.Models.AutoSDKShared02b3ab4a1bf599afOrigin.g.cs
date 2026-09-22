
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared02b3ab4a1bf599afOrigin
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
    public static class AutoSDKShared02b3ab4a1bf599afOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared02b3ab4a1bf599afOrigin value)
        {
            return value switch
            {
                AutoSDKShared02b3ab4a1bf599afOrigin.External => "external",
                AutoSDKShared02b3ab4a1bf599afOrigin.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared02b3ab4a1bf599afOrigin? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKShared02b3ab4a1bf599afOrigin.External,
                "vercel" => AutoSDKShared02b3ab4a1bf599afOrigin.Vercel,
                _ => null,
            };
        }
    }
}
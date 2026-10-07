
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedebbc2ea34af24e22SourceVariant4Origin
    {
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedebbc2ea34af24e22SourceVariant4OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedebbc2ea34af24e22SourceVariant4Origin value)
        {
            return value switch
            {
                AutoSDKSharedebbc2ea34af24e22SourceVariant4Origin.Api => "api",
                AutoSDKSharedebbc2ea34af24e22SourceVariant4Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedebbc2ea34af24e22SourceVariant4Origin? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKSharedebbc2ea34af24e22SourceVariant4Origin.Api,
                "platform" => AutoSDKSharedebbc2ea34af24e22SourceVariant4Origin.Platform,
                _ => null,
            };
        }
    }
}
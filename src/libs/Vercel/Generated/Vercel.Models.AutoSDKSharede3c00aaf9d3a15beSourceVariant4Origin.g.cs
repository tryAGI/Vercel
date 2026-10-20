
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede3c00aaf9d3a15beSourceVariant4Origin
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
    public static class AutoSDKSharede3c00aaf9d3a15beSourceVariant4OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede3c00aaf9d3a15beSourceVariant4Origin value)
        {
            return value switch
            {
                AutoSDKSharede3c00aaf9d3a15beSourceVariant4Origin.Api => "api",
                AutoSDKSharede3c00aaf9d3a15beSourceVariant4Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede3c00aaf9d3a15beSourceVariant4Origin? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKSharede3c00aaf9d3a15beSourceVariant4Origin.Api,
                "platform" => AutoSDKSharede3c00aaf9d3a15beSourceVariant4Origin.Platform,
                _ => null,
            };
        }
    }
}
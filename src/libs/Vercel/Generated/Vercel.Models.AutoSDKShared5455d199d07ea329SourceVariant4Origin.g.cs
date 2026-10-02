
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5455d199d07ea329SourceVariant4Origin
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
    public static class AutoSDKShared5455d199d07ea329SourceVariant4OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5455d199d07ea329SourceVariant4Origin value)
        {
            return value switch
            {
                AutoSDKShared5455d199d07ea329SourceVariant4Origin.Api => "api",
                AutoSDKShared5455d199d07ea329SourceVariant4Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5455d199d07ea329SourceVariant4Origin? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKShared5455d199d07ea329SourceVariant4Origin.Api,
                "platform" => AutoSDKShared5455d199d07ea329SourceVariant4Origin.Platform,
                _ => null,
            };
        }
    }
}
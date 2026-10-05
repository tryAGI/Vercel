
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared87d88207314b07b3SourceVariant4Origin
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
    public static class AutoSDKShared87d88207314b07b3SourceVariant4OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared87d88207314b07b3SourceVariant4Origin value)
        {
            return value switch
            {
                AutoSDKShared87d88207314b07b3SourceVariant4Origin.Api => "api",
                AutoSDKShared87d88207314b07b3SourceVariant4Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared87d88207314b07b3SourceVariant4Origin? ToEnum(string value)
        {
            return value switch
            {
                "api" => AutoSDKShared87d88207314b07b3SourceVariant4Origin.Api,
                "platform" => AutoSDKShared87d88207314b07b3SourceVariant4Origin.Platform,
                _ => null,
            };
        }
    }
}
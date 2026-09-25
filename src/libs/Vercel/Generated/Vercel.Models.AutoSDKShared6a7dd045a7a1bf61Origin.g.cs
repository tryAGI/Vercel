
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6a7dd045a7a1bf61Origin
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
    public static class AutoSDKShared6a7dd045a7a1bf61OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6a7dd045a7a1bf61Origin value)
        {
            return value switch
            {
                AutoSDKShared6a7dd045a7a1bf61Origin.External => "external",
                AutoSDKShared6a7dd045a7a1bf61Origin.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6a7dd045a7a1bf61Origin? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKShared6a7dd045a7a1bf61Origin.External,
                "vercel" => AutoSDKShared6a7dd045a7a1bf61Origin.Vercel,
                _ => null,
            };
        }
    }
}
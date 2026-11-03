
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bb335e8fa392fa3Origin
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
    public static class AutoSDKShared6bb335e8fa392fa3OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bb335e8fa392fa3Origin value)
        {
            return value switch
            {
                AutoSDKShared6bb335e8fa392fa3Origin.External => "external",
                AutoSDKShared6bb335e8fa392fa3Origin.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bb335e8fa392fa3Origin? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKShared6bb335e8fa392fa3Origin.External,
                "vercel" => AutoSDKShared6bb335e8fa392fa3Origin.Vercel,
                _ => null,
            };
        }
    }
}
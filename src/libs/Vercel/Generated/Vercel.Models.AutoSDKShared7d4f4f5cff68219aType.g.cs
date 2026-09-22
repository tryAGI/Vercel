
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment (production, preview, or development)
    /// </summary>
    public enum AutoSDKShared7d4f4f5cff68219aType
    {
        /// <summary>
        ///
        /// </summary>
        Development,
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared7d4f4f5cff68219aTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7d4f4f5cff68219aType value)
        {
            return value switch
            {
                AutoSDKShared7d4f4f5cff68219aType.Development => "development",
                AutoSDKShared7d4f4f5cff68219aType.Preview => "preview",
                AutoSDKShared7d4f4f5cff68219aType.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7d4f4f5cff68219aType? ToEnum(string value)
        {
            return value switch
            {
                "development" => AutoSDKShared7d4f4f5cff68219aType.Development,
                "preview" => AutoSDKShared7d4f4f5cff68219aType.Preview,
                "production" => AutoSDKShared7d4f4f5cff68219aType.Production,
                _ => null,
            };
        }
    }
}
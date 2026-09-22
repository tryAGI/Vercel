
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2c06e7f88512c8b8ItemsType
    {
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2c06e7f88512c8b8ItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2c06e7f88512c8b8ItemsType value)
        {
            return value switch
            {
                AutoSDKShared2c06e7f88512c8b8ItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2c06e7f88512c8b8ItemsType? ToEnum(string value)
        {
            return value switch
            {
                "string" => AutoSDKShared2c06e7f88512c8b8ItemsType.String,
                _ => null,
            };
        }
    }
}
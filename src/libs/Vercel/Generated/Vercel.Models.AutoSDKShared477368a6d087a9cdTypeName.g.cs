
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared477368a6d087a9cdTypeName
    {
        /// <summary>
        ///
        /// </summary>
        Flag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared477368a6d087a9cdTypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared477368a6d087a9cdTypeName value)
        {
            return value switch
            {
                AutoSDKShared477368a6d087a9cdTypeName.Flag => "flag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared477368a6d087a9cdTypeName? ToEnum(string value)
        {
            return value switch
            {
                "flag" => AutoSDKShared477368a6d087a9cdTypeName.Flag,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedaf3e034232cd964aItemsType
    {
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedaf3e034232cd964aItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedaf3e034232cd964aItemsType value)
        {
            return value switch
            {
                AutoSDKSharedaf3e034232cd964aItemsType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedaf3e034232cd964aItemsType? ToEnum(string value)
        {
            return value switch
            {
                "string" => AutoSDKSharedaf3e034232cd964aItemsType.String,
                _ => null,
            };
        }
    }
}
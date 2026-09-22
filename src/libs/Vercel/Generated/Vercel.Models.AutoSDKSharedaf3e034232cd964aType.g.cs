
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedaf3e034232cd964aType
    {
        /// <summary>
        ///
        /// </summary>
        Array,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedaf3e034232cd964aTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedaf3e034232cd964aType value)
        {
            return value switch
            {
                AutoSDKSharedaf3e034232cd964aType.Array => "array",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedaf3e034232cd964aType? ToEnum(string value)
        {
            return value switch
            {
                "array" => AutoSDKSharedaf3e034232cd964aType.Array,
                _ => null,
            };
        }
    }
}
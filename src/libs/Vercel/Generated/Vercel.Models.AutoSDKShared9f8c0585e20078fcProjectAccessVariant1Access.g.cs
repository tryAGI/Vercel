
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9f8c0585e20078fcProjectAccessVariant1Access
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9f8c0585e20078fcProjectAccessVariant1AccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9f8c0585e20078fcProjectAccessVariant1Access value)
        {
            return value switch
            {
                AutoSDKShared9f8c0585e20078fcProjectAccessVariant1Access.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9f8c0585e20078fcProjectAccessVariant1Access? ToEnum(string value)
        {
            return value switch
            {
                "all" => AutoSDKShared9f8c0585e20078fcProjectAccessVariant1Access.All,
                _ => null,
            };
        }
    }
}
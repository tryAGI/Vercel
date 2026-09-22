
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0603220ab3785539Type
    {
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0603220ab3785539TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0603220ab3785539Type value)
        {
            return value switch
            {
                AutoSDKShared0603220ab3785539Type.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0603220ab3785539Type? ToEnum(string value)
        {
            return value switch
            {
                "string" => AutoSDKShared0603220ab3785539Type.String,
                _ => null,
            };
        }
    }
}
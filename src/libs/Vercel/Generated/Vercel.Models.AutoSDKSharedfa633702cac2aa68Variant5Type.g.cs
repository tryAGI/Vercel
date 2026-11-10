
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa633702cac2aa68Variant5Type
    {
        /// <summary>
        ///
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfa633702cac2aa68Variant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa633702cac2aa68Variant5Type value)
        {
            return value switch
            {
                AutoSDKSharedfa633702cac2aa68Variant5Type.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa633702cac2aa68Variant5Type? ToEnum(string value)
        {
            return value switch
            {
                "internal" => AutoSDKSharedfa633702cac2aa68Variant5Type.Internal,
                _ => null,
            };
        }
    }
}
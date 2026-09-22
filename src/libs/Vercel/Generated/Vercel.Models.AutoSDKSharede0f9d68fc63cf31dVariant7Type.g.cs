
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0f9d68fc63cf31dVariant7Type
    {
        /// <summary>
        ///
        /// </summary>
        V0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede0f9d68fc63cf31dVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0f9d68fc63cf31dVariant7Type value)
        {
            return value switch
            {
                AutoSDKSharede0f9d68fc63cf31dVariant7Type.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0f9d68fc63cf31dVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "v0" => AutoSDKSharede0f9d68fc63cf31dVariant7Type.V0,
                _ => null,
            };
        }
    }
}
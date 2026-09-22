
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede0f9d68fc63cf31dVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede0f9d68fc63cf31dVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede0f9d68fc63cf31dVariant5Type value)
        {
            return value switch
            {
                AutoSDKSharede0f9d68fc63cf31dVariant5Type.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede0f9d68fc63cf31dVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => AutoSDKSharede0f9d68fc63cf31dVariant5Type.Bitbucket,
                _ => null,
            };
        }
    }
}
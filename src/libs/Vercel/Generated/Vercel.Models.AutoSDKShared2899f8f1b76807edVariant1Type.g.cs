
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2899f8f1b76807edVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2899f8f1b76807edVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2899f8f1b76807edVariant1Type value)
        {
            return value switch
            {
                AutoSDKShared2899f8f1b76807edVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2899f8f1b76807edVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => AutoSDKShared2899f8f1b76807edVariant1Type.User,
                _ => null,
            };
        }
    }
}
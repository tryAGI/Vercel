
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2899f8f1b76807edVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2899f8f1b76807edVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2899f8f1b76807edVariant3Type value)
        {
            return value switch
            {
                AutoSDKShared2899f8f1b76807edVariant3Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2899f8f1b76807edVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => AutoSDKShared2899f8f1b76807edVariant3Type.App,
                _ => null,
            };
        }
    }
}
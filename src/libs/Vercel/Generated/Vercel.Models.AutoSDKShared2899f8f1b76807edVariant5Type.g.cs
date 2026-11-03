
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2899f8f1b76807edVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2899f8f1b76807edVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2899f8f1b76807edVariant5Type value)
        {
            return value switch
            {
                AutoSDKShared2899f8f1b76807edVariant5Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2899f8f1b76807edVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => AutoSDKShared2899f8f1b76807edVariant5Type.System,
                _ => null,
            };
        }
    }
}
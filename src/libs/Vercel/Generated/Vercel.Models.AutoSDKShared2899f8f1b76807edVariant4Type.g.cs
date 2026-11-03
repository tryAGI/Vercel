
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2899f8f1b76807edVariant4Type
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2899f8f1b76807edVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2899f8f1b76807edVariant4Type value)
        {
            return value switch
            {
                AutoSDKShared2899f8f1b76807edVariant4Type.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2899f8f1b76807edVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "integration" => AutoSDKShared2899f8f1b76807edVariant4Type.Integration,
                _ => null,
            };
        }
    }
}
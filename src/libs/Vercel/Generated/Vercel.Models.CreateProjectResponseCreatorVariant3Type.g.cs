
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseCreatorVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseCreatorVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseCreatorVariant3Type value)
        {
            return value switch
            {
                CreateProjectResponseCreatorVariant3Type.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseCreatorVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "integration" => CreateProjectResponseCreatorVariant3Type.Integration,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseCreatorVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseCreatorVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseCreatorVariant4Type value)
        {
            return value switch
            {
                CreateProjectResponseCreatorVariant4Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseCreatorVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "system" => CreateProjectResponseCreatorVariant4Type.System,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseLinkVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseLinkVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseLinkVariant6Type value)
        {
            return value switch
            {
                CreateProjectResponseLinkVariant6Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseLinkVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "vercel" => CreateProjectResponseLinkVariant6Type.Vercel,
                _ => null,
            };
        }
    }
}
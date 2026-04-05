
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseLinkVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseLinkVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseLinkVariant1Type value)
        {
            return value switch
            {
                UpdateProjectResponseLinkVariant1Type.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseLinkVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "github" => UpdateProjectResponseLinkVariant1Type.Github,
                _ => null,
            };
        }
    }
}
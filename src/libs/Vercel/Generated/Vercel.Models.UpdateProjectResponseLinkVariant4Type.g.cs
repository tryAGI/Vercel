
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseLinkVariant4Type
    {
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseLinkVariant4TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseLinkVariant4Type value)
        {
            return value switch
            {
                UpdateProjectResponseLinkVariant4Type.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseLinkVariant4Type? ToEnum(string value)
        {
            return value switch
            {
                "gitlab" => UpdateProjectResponseLinkVariant4Type.Gitlab,
                _ => null,
            };
        }
    }
}
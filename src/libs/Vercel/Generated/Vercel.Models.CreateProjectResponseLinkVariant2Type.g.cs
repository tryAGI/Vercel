
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseLinkVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubLimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseLinkVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseLinkVariant2Type value)
        {
            return value switch
            {
                CreateProjectResponseLinkVariant2Type.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseLinkVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "github-limited" => CreateProjectResponseLinkVariant2Type.GithubLimited,
                _ => null,
            };
        }
    }
}
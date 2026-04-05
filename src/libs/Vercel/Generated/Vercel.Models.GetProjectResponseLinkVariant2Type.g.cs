
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseLinkVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubLimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseLinkVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLinkVariant2Type value)
        {
            return value switch
            {
                GetProjectResponseLinkVariant2Type.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLinkVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "github-limited" => GetProjectResponseLinkVariant2Type.GithubLimited,
                _ => null,
            };
        }
    }
}
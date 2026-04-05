
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemLinkVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubLimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemLinkVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemLinkVariant2Type value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemLinkVariant2Type.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemLinkVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "github-limited" => GetProjectsResponseVariant1ItemLinkVariant2Type.GithubLimited,
                _ => null,
            };
        }
    }
}
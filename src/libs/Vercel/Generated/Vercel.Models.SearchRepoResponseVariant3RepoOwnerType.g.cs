
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchRepoResponseVariant3RepoOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRepoResponseVariant3RepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRepoResponseVariant3RepoOwnerType value)
        {
            return value switch
            {
                SearchRepoResponseVariant3RepoOwnerType.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRepoResponseVariant3RepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => SearchRepoResponseVariant3RepoOwnerType.Team,
                _ => null,
            };
        }
    }
}
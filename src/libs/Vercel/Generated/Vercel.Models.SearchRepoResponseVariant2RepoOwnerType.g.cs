
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchRepoResponseVariant2RepoOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRepoResponseVariant2RepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRepoResponseVariant2RepoOwnerType value)
        {
            return value switch
            {
                SearchRepoResponseVariant2RepoOwnerType.Team => "team",
                SearchRepoResponseVariant2RepoOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRepoResponseVariant2RepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => SearchRepoResponseVariant2RepoOwnerType.Team,
                "user" => SearchRepoResponseVariant2RepoOwnerType.User,
                _ => null,
            };
        }
    }
}
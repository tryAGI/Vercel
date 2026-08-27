
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchRepoResponseVariant4RepoOwnerType
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
    public static class SearchRepoResponseVariant4RepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRepoResponseVariant4RepoOwnerType value)
        {
            return value switch
            {
                SearchRepoResponseVariant4RepoOwnerType.Team => "team",
                SearchRepoResponseVariant4RepoOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRepoResponseVariant4RepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "team" => SearchRepoResponseVariant4RepoOwnerType.Team,
                "user" => SearchRepoResponseVariant4RepoOwnerType.User,
                _ => null,
            };
        }
    }
}
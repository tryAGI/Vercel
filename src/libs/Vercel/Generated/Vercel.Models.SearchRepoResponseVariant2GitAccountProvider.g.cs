
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchRepoResponseVariant2GitAccountProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        GithubCustomHost,
        /// <summary>
        /// 
        /// </summary>
        GithubLimited,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRepoResponseVariant2GitAccountProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRepoResponseVariant2GitAccountProvider value)
        {
            return value switch
            {
                SearchRepoResponseVariant2GitAccountProvider.Bitbucket => "bitbucket",
                SearchRepoResponseVariant2GitAccountProvider.Github => "github",
                SearchRepoResponseVariant2GitAccountProvider.GithubCustomHost => "github-custom-host",
                SearchRepoResponseVariant2GitAccountProvider.GithubLimited => "github-limited",
                SearchRepoResponseVariant2GitAccountProvider.Gitlab => "gitlab",
                SearchRepoResponseVariant2GitAccountProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRepoResponseVariant2GitAccountProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => SearchRepoResponseVariant2GitAccountProvider.Bitbucket,
                "github" => SearchRepoResponseVariant2GitAccountProvider.Github,
                "github-custom-host" => SearchRepoResponseVariant2GitAccountProvider.GithubCustomHost,
                "github-limited" => SearchRepoResponseVariant2GitAccountProvider.GithubLimited,
                "gitlab" => SearchRepoResponseVariant2GitAccountProvider.Gitlab,
                "vercel" => SearchRepoResponseVariant2GitAccountProvider.Vercel,
                _ => null,
            };
        }
    }
}
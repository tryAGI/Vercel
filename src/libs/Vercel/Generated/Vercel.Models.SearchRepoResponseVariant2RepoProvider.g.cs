
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchRepoResponseVariant2RepoProvider
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
    public static class SearchRepoResponseVariant2RepoProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRepoResponseVariant2RepoProvider value)
        {
            return value switch
            {
                SearchRepoResponseVariant2RepoProvider.Bitbucket => "bitbucket",
                SearchRepoResponseVariant2RepoProvider.Github => "github",
                SearchRepoResponseVariant2RepoProvider.GithubCustomHost => "github-custom-host",
                SearchRepoResponseVariant2RepoProvider.GithubLimited => "github-limited",
                SearchRepoResponseVariant2RepoProvider.Gitlab => "gitlab",
                SearchRepoResponseVariant2RepoProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRepoResponseVariant2RepoProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => SearchRepoResponseVariant2RepoProvider.Bitbucket,
                "github" => SearchRepoResponseVariant2RepoProvider.Github,
                "github-custom-host" => SearchRepoResponseVariant2RepoProvider.GithubCustomHost,
                "github-limited" => SearchRepoResponseVariant2RepoProvider.GithubLimited,
                "gitlab" => SearchRepoResponseVariant2RepoProvider.Gitlab,
                "vercel" => SearchRepoResponseVariant2RepoProvider.Vercel,
                _ => null,
            };
        }
    }
}
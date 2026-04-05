
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchRepoProvider
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRepoProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRepoProvider value)
        {
            return value switch
            {
                SearchRepoProvider.Bitbucket => "bitbucket",
                SearchRepoProvider.Github => "github",
                SearchRepoProvider.GithubCustomHost => "github-custom-host",
                SearchRepoProvider.GithubLimited => "github-limited",
                SearchRepoProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRepoProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => SearchRepoProvider.Bitbucket,
                "github" => SearchRepoProvider.Github,
                "github-custom-host" => SearchRepoProvider.GithubCustomHost,
                "github-limited" => SearchRepoProvider.GithubLimited,
                "gitlab" => SearchRepoProvider.Gitlab,
                _ => null,
            };
        }
    }
}
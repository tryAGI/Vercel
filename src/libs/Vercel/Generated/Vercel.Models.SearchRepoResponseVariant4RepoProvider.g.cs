
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchRepoResponseVariant4RepoProvider
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
    public static class SearchRepoResponseVariant4RepoProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRepoResponseVariant4RepoProvider value)
        {
            return value switch
            {
                SearchRepoResponseVariant4RepoProvider.Bitbucket => "bitbucket",
                SearchRepoResponseVariant4RepoProvider.Github => "github",
                SearchRepoResponseVariant4RepoProvider.GithubCustomHost => "github-custom-host",
                SearchRepoResponseVariant4RepoProvider.GithubLimited => "github-limited",
                SearchRepoResponseVariant4RepoProvider.Gitlab => "gitlab",
                SearchRepoResponseVariant4RepoProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRepoResponseVariant4RepoProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => SearchRepoResponseVariant4RepoProvider.Bitbucket,
                "github" => SearchRepoResponseVariant4RepoProvider.Github,
                "github-custom-host" => SearchRepoResponseVariant4RepoProvider.GithubCustomHost,
                "github-limited" => SearchRepoResponseVariant4RepoProvider.GithubLimited,
                "gitlab" => SearchRepoResponseVariant4RepoProvider.Gitlab,
                "vercel" => SearchRepoResponseVariant4RepoProvider.Vercel,
                _ => null,
            };
        }
    }
}
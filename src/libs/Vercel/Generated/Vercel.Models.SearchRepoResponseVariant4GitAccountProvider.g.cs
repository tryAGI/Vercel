
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchRepoResponseVariant4GitAccountProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        CursorOrigin,
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
    public static class SearchRepoResponseVariant4GitAccountProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRepoResponseVariant4GitAccountProvider value)
        {
            return value switch
            {
                SearchRepoResponseVariant4GitAccountProvider.Bitbucket => "bitbucket",
                SearchRepoResponseVariant4GitAccountProvider.CursorOrigin => "cursor-origin",
                SearchRepoResponseVariant4GitAccountProvider.Github => "github",
                SearchRepoResponseVariant4GitAccountProvider.GithubCustomHost => "github-custom-host",
                SearchRepoResponseVariant4GitAccountProvider.GithubLimited => "github-limited",
                SearchRepoResponseVariant4GitAccountProvider.Gitlab => "gitlab",
                SearchRepoResponseVariant4GitAccountProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRepoResponseVariant4GitAccountProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => SearchRepoResponseVariant4GitAccountProvider.Bitbucket,
                "cursor-origin" => SearchRepoResponseVariant4GitAccountProvider.CursorOrigin,
                "github" => SearchRepoResponseVariant4GitAccountProvider.Github,
                "github-custom-host" => SearchRepoResponseVariant4GitAccountProvider.GithubCustomHost,
                "github-limited" => SearchRepoResponseVariant4GitAccountProvider.GithubLimited,
                "gitlab" => SearchRepoResponseVariant4GitAccountProvider.Gitlab,
                "vercel" => SearchRepoResponseVariant4GitAccountProvider.Vercel,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GitNamespacesProvider
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
    public static class GitNamespacesProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GitNamespacesProvider value)
        {
            return value switch
            {
                GitNamespacesProvider.Bitbucket => "bitbucket",
                GitNamespacesProvider.Github => "github",
                GitNamespacesProvider.GithubCustomHost => "github-custom-host",
                GitNamespacesProvider.GithubLimited => "github-limited",
                GitNamespacesProvider.Gitlab => "gitlab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GitNamespacesProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GitNamespacesProvider.Bitbucket,
                "github" => GitNamespacesProvider.Github,
                "github-custom-host" => GitNamespacesProvider.GithubCustomHost,
                "github-limited" => GitNamespacesProvider.GithubLimited,
                "gitlab" => GitNamespacesProvider.Gitlab,
                _ => null,
            };
        }
    }
}
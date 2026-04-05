
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthUserImportFlowGitProvider
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
    public static class AuthUserImportFlowGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthUserImportFlowGitProvider value)
        {
            return value switch
            {
                AuthUserImportFlowGitProvider.Bitbucket => "bitbucket",
                AuthUserImportFlowGitProvider.Github => "github",
                AuthUserImportFlowGitProvider.GithubCustomHost => "github-custom-host",
                AuthUserImportFlowGitProvider.GithubLimited => "github-limited",
                AuthUserImportFlowGitProvider.Gitlab => "gitlab",
                AuthUserImportFlowGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthUserImportFlowGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => AuthUserImportFlowGitProvider.Bitbucket,
                "github" => AuthUserImportFlowGitProvider.Github,
                "github-custom-host" => AuthUserImportFlowGitProvider.GithubCustomHost,
                "github-limited" => AuthUserImportFlowGitProvider.GithubLimited,
                "gitlab" => AuthUserImportFlowGitProvider.Gitlab,
                "vercel" => AuthUserImportFlowGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
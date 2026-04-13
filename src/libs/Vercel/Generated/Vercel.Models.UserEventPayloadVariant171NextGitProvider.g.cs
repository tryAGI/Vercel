
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant171NextGitProvider
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
    public static class UserEventPayloadVariant171NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant171NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant171NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant171NextGitProvider.Github => "github",
                UserEventPayloadVariant171NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant171NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant171NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant171NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant171NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant171NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant171NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant171NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant171NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant171NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant171NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant184NextGitProvider
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
    public static class UserEventPayloadVariant184NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant184NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant184NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant184NextGitProvider.Github => "github",
                UserEventPayloadVariant184NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant184NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant184NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant184NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant184NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant184NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant184NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant184NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant184NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant184NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant184NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
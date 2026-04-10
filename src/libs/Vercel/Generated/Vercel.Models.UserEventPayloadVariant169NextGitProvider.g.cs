
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant169NextGitProvider
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
    public static class UserEventPayloadVariant169NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant169NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant169NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant169NextGitProvider.Github => "github",
                UserEventPayloadVariant169NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant169NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant169NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant169NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant169NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant169NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant169NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant169NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant169NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant169NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant169NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
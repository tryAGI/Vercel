
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant172NextGitProvider
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
    public static class UserEventPayloadVariant172NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant172NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant172NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant172NextGitProvider.Github => "github",
                UserEventPayloadVariant172NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant172NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant172NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant172NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant172NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant172NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant172NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant172NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant172NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant172NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant172NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
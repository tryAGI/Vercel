
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant167NextGitProvider
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
    public static class UserEventPayloadVariant167NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant167NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant167NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant167NextGitProvider.Github => "github",
                UserEventPayloadVariant167NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant167NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant167NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant167NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant167NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant167NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant167NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant167NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant167NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant167NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant167NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
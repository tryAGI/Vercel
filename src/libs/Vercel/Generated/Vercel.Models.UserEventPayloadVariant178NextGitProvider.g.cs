
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant178NextGitProvider
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
    public static class UserEventPayloadVariant178NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant178NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant178NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant178NextGitProvider.Github => "github",
                UserEventPayloadVariant178NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant178NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant178NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant178NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant178NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant178NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant178NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant178NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant178NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant178NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant178NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
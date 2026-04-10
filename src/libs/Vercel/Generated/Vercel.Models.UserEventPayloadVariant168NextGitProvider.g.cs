
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant168NextGitProvider
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
    public static class UserEventPayloadVariant168NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant168NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant168NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant168NextGitProvider.Github => "github",
                UserEventPayloadVariant168NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant168NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant168NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant168NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant168NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant168NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant168NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant168NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant168NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant168NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant168NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
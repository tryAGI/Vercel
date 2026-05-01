
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant187NextGitProvider
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
    public static class UserEventPayloadVariant187NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant187NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant187NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant187NextGitProvider.Github => "github",
                UserEventPayloadVariant187NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant187NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant187NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant187NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant187NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant187NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant187NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant187NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant187NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant187NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant187NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
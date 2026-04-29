
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant186NextGitProvider
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
    public static class UserEventPayloadVariant186NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant186NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant186NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant186NextGitProvider.Github => "github",
                UserEventPayloadVariant186NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant186NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant186NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant186NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant186NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant186NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant186NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant186NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant186NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant186NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant186NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
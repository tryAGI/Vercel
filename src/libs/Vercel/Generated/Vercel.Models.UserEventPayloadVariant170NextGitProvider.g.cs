
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant170NextGitProvider
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
    public static class UserEventPayloadVariant170NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant170NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant170NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant170NextGitProvider.Github => "github",
                UserEventPayloadVariant170NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant170NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant170NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant170NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant170NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant170NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant170NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant170NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant170NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant170NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant170NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
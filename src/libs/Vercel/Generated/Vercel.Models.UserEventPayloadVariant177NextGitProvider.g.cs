
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant177NextGitProvider
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
    public static class UserEventPayloadVariant177NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant177NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant177NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant177NextGitProvider.Github => "github",
                UserEventPayloadVariant177NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant177NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant177NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant177NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant177NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant177NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant177NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant177NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant177NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant177NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant177NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
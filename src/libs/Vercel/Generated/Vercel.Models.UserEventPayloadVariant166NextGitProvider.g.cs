
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant166NextGitProvider
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
    public static class UserEventPayloadVariant166NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant166NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant166NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant166NextGitProvider.Github => "github",
                UserEventPayloadVariant166NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant166NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant166NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant166NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant166NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant166NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant166NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant166NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant166NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant166NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant166NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
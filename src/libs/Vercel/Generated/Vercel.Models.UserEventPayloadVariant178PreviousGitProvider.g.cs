
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant178PreviousGitProvider
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
    public static class UserEventPayloadVariant178PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant178PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant178PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant178PreviousGitProvider.Github => "github",
                UserEventPayloadVariant178PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant178PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant178PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant178PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant178PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant178PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant178PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant178PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant178PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant178PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant178PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
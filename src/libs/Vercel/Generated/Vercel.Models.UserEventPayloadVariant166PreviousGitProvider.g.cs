
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant166PreviousGitProvider
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
    public static class UserEventPayloadVariant166PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant166PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant166PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant166PreviousGitProvider.Github => "github",
                UserEventPayloadVariant166PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant166PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant166PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant166PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant166PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant166PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant166PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant166PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant166PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant166PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant166PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
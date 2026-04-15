
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant172PreviousGitProvider
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
    public static class UserEventPayloadVariant172PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant172PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant172PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant172PreviousGitProvider.Github => "github",
                UserEventPayloadVariant172PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant172PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant172PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant172PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant172PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant172PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant172PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant172PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant172PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant172PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant172PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
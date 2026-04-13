
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant171PreviousGitProvider
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
    public static class UserEventPayloadVariant171PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant171PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant171PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant171PreviousGitProvider.Github => "github",
                UserEventPayloadVariant171PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant171PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant171PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant171PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant171PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant171PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant171PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant171PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant171PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant171PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant171PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
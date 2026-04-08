
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant167PreviousGitProvider
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
    public static class UserEventPayloadVariant167PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant167PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant167PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant167PreviousGitProvider.Github => "github",
                UserEventPayloadVariant167PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant167PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant167PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant167PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant167PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant167PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant167PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant167PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant167PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant167PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant167PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
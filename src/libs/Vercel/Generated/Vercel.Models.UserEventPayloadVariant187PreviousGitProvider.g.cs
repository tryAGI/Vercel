
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant187PreviousGitProvider
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
    public static class UserEventPayloadVariant187PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant187PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant187PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant187PreviousGitProvider.Github => "github",
                UserEventPayloadVariant187PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant187PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant187PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant187PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant187PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant187PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant187PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant187PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant187PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant187PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant187PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
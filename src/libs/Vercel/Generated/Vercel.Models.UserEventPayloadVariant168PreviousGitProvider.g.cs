
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant168PreviousGitProvider
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
    public static class UserEventPayloadVariant168PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant168PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant168PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant168PreviousGitProvider.Github => "github",
                UserEventPayloadVariant168PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant168PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant168PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant168PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant168PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant168PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant168PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant168PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant168PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant168PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant168PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
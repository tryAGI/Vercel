
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant186PreviousGitProvider
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
    public static class UserEventPayloadVariant186PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant186PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant186PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant186PreviousGitProvider.Github => "github",
                UserEventPayloadVariant186PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant186PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant186PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant186PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant186PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant186PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant186PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant186PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant186PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant186PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant186PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
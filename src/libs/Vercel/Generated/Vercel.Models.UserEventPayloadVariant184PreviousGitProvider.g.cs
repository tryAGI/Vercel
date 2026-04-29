
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant184PreviousGitProvider
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
    public static class UserEventPayloadVariant184PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant184PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant184PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant184PreviousGitProvider.Github => "github",
                UserEventPayloadVariant184PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant184PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant184PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant184PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant184PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant184PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant184PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant184PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant184PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant184PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant184PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
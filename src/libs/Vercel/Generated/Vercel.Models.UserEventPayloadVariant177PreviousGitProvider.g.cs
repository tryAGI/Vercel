
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant177PreviousGitProvider
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
    public static class UserEventPayloadVariant177PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant177PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant177PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant177PreviousGitProvider.Github => "github",
                UserEventPayloadVariant177PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant177PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant177PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant177PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant177PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant177PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant177PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant177PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant177PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant177PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant177PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
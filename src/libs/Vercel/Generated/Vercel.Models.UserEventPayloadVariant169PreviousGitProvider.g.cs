
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant169PreviousGitProvider
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
    public static class UserEventPayloadVariant169PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant169PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant169PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant169PreviousGitProvider.Github => "github",
                UserEventPayloadVariant169PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant169PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant169PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant169PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant169PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant169PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant169PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant169PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant169PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant169PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant169PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
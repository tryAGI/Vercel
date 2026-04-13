
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant170PreviousGitProvider
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
    public static class UserEventPayloadVariant170PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant170PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant170PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant170PreviousGitProvider.Github => "github",
                UserEventPayloadVariant170PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant170PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant170PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant170PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant170PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant170PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant170PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant170PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant170PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant170PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant170PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
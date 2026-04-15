
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant175PreviousGitProvider
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
    public static class UserEventPayloadVariant175PreviousGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant175PreviousGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant175PreviousGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant175PreviousGitProvider.Github => "github",
                UserEventPayloadVariant175PreviousGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant175PreviousGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant175PreviousGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant175PreviousGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant175PreviousGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant175PreviousGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant175PreviousGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant175PreviousGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant175PreviousGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant175PreviousGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant175PreviousGitProvider.Vercel,
                _ => null,
            };
        }
    }
}
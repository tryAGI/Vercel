
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant175NextGitProvider
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
    public static class UserEventPayloadVariant175NextGitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant175NextGitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant175NextGitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant175NextGitProvider.Github => "github",
                UserEventPayloadVariant175NextGitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant175NextGitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant175NextGitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant175NextGitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant175NextGitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant175NextGitProvider.Bitbucket,
                "github" => UserEventPayloadVariant175NextGitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant175NextGitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant175NextGitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant175NextGitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant175NextGitProvider.Vercel,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant178GitProvider
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
    public static class UserEventPayloadVariant178GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant178GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant178GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant178GitProvider.Github => "github",
                UserEventPayloadVariant178GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant178GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant178GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant178GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant178GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant178GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant178GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant178GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant178GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant178GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant178GitProvider.Vercel,
                _ => null,
            };
        }
    }
}
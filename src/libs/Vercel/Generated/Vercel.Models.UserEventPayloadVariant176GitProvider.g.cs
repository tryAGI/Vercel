
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant176GitProvider
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
    public static class UserEventPayloadVariant176GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant176GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant176GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant176GitProvider.Github => "github",
                UserEventPayloadVariant176GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant176GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant176GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant176GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant176GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant176GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant176GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant176GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant176GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant176GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant176GitProvider.Vercel,
                _ => null,
            };
        }
    }
}
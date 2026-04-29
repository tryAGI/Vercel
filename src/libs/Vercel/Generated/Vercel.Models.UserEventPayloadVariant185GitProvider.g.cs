
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant185GitProvider
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
    public static class UserEventPayloadVariant185GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant185GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant185GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant185GitProvider.Github => "github",
                UserEventPayloadVariant185GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant185GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant185GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant185GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant185GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant185GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant185GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant185GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant185GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant185GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant185GitProvider.Vercel,
                _ => null,
            };
        }
    }
}
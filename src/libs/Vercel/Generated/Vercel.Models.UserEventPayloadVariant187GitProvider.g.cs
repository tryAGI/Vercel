
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant187GitProvider
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
    public static class UserEventPayloadVariant187GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant187GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant187GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant187GitProvider.Github => "github",
                UserEventPayloadVariant187GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant187GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant187GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant187GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant187GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant187GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant187GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant187GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant187GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant187GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant187GitProvider.Vercel,
                _ => null,
            };
        }
    }
}
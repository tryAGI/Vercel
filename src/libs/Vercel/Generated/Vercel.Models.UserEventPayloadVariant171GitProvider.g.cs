
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant171GitProvider
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
    public static class UserEventPayloadVariant171GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant171GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant171GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant171GitProvider.Github => "github",
                UserEventPayloadVariant171GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant171GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant171GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant171GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant171GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant171GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant171GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant171GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant171GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant171GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant171GitProvider.Vercel,
                _ => null,
            };
        }
    }
}
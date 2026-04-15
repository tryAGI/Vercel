
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant173GitProvider
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
    public static class UserEventPayloadVariant173GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant173GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant173GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant173GitProvider.Github => "github",
                UserEventPayloadVariant173GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant173GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant173GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant173GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant173GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant173GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant173GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant173GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant173GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant173GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant173GitProvider.Vercel,
                _ => null,
            };
        }
    }
}
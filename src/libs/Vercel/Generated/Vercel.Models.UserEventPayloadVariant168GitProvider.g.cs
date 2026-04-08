
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant168GitProvider
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
    public static class UserEventPayloadVariant168GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant168GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant168GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant168GitProvider.Github => "github",
                UserEventPayloadVariant168GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant168GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant168GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant168GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant168GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant168GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant168GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant168GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant168GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant168GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant168GitProvider.Vercel,
                _ => null,
            };
        }
    }
}
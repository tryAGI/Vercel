
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant170GitProvider
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
    public static class UserEventPayloadVariant170GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant170GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant170GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant170GitProvider.Github => "github",
                UserEventPayloadVariant170GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant170GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant170GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant170GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant170GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant170GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant170GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant170GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant170GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant170GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant170GitProvider.Vercel,
                _ => null,
            };
        }
    }
}
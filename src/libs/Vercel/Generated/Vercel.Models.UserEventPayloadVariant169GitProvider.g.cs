
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant169GitProvider
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
    public static class UserEventPayloadVariant169GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant169GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant169GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant169GitProvider.Github => "github",
                UserEventPayloadVariant169GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant169GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant169GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant169GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant169GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant169GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant169GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant169GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant169GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant169GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant169GitProvider.Vercel,
                _ => null,
            };
        }
    }
}
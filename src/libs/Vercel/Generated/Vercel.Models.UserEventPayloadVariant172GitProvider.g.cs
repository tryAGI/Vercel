
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant172GitProvider
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
    public static class UserEventPayloadVariant172GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant172GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant172GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant172GitProvider.Github => "github",
                UserEventPayloadVariant172GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant172GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant172GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant172GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant172GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant172GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant172GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant172GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant172GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant172GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant172GitProvider.Vercel,
                _ => null,
            };
        }
    }
}
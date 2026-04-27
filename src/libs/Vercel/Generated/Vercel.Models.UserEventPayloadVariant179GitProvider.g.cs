
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant179GitProvider
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
    public static class UserEventPayloadVariant179GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant179GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant179GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant179GitProvider.Github => "github",
                UserEventPayloadVariant179GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant179GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant179GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant179GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant179GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant179GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant179GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant179GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant179GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant179GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant179GitProvider.Vercel,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant188GitProvider
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
    public static class UserEventPayloadVariant188GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant188GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant188GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant188GitProvider.Github => "github",
                UserEventPayloadVariant188GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant188GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant188GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant188GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant188GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant188GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant188GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant188GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant188GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant188GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant188GitProvider.Vercel,
                _ => null,
            };
        }
    }
}
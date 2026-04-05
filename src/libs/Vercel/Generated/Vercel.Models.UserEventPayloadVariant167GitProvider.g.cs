
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant167GitProvider
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
    public static class UserEventPayloadVariant167GitProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant167GitProvider value)
        {
            return value switch
            {
                UserEventPayloadVariant167GitProvider.Bitbucket => "bitbucket",
                UserEventPayloadVariant167GitProvider.Github => "github",
                UserEventPayloadVariant167GitProvider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant167GitProvider.GithubLimited => "github-limited",
                UserEventPayloadVariant167GitProvider.Gitlab => "gitlab",
                UserEventPayloadVariant167GitProvider.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant167GitProvider? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant167GitProvider.Bitbucket,
                "github" => UserEventPayloadVariant167GitProvider.Github,
                "github-custom-host" => UserEventPayloadVariant167GitProvider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant167GitProvider.GithubLimited,
                "gitlab" => UserEventPayloadVariant167GitProvider.Gitlab,
                "vercel" => UserEventPayloadVariant167GitProvider.Vercel,
                _ => null,
            };
        }
    }
}
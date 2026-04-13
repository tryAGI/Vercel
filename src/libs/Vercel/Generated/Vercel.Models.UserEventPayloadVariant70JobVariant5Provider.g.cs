
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant70JobVariant5Provider
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant70JobVariant5ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant70JobVariant5Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant70JobVariant5Provider.Github => "github",
                UserEventPayloadVariant70JobVariant5Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant70JobVariant5Provider.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant70JobVariant5Provider? ToEnum(string value)
        {
            return value switch
            {
                "github" => UserEventPayloadVariant70JobVariant5Provider.Github,
                "github-custom-host" => UserEventPayloadVariant70JobVariant5Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant70JobVariant5Provider.GithubLimited,
                _ => null,
            };
        }
    }
}
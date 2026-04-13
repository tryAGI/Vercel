
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant70JobVariant3Provider
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
    public static class UserEventPayloadVariant70JobVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant70JobVariant3Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant70JobVariant3Provider.Github => "github",
                UserEventPayloadVariant70JobVariant3Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant70JobVariant3Provider.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant70JobVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "github" => UserEventPayloadVariant70JobVariant3Provider.Github,
                "github-custom-host" => UserEventPayloadVariant70JobVariant3Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant70JobVariant3Provider.GithubLimited,
                _ => null,
            };
        }
    }
}
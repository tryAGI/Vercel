
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant69JobVariant3Provider
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
    public static class UserEventPayloadVariant69JobVariant3ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant69JobVariant3Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant69JobVariant3Provider.Github => "github",
                UserEventPayloadVariant69JobVariant3Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant69JobVariant3Provider.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant69JobVariant3Provider? ToEnum(string value)
        {
            return value switch
            {
                "github" => UserEventPayloadVariant69JobVariant3Provider.Github,
                "github-custom-host" => UserEventPayloadVariant69JobVariant3Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant69JobVariant3Provider.GithubLimited,
                _ => null,
            };
        }
    }
}
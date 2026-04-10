
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant69JobVariant4Provider
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
    public static class UserEventPayloadVariant69JobVariant4ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant69JobVariant4Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant69JobVariant4Provider.Github => "github",
                UserEventPayloadVariant69JobVariant4Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant69JobVariant4Provider.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant69JobVariant4Provider? ToEnum(string value)
        {
            return value switch
            {
                "github" => UserEventPayloadVariant69JobVariant4Provider.Github,
                "github-custom-host" => UserEventPayloadVariant69JobVariant4Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant69JobVariant4Provider.GithubLimited,
                _ => null,
            };
        }
    }
}
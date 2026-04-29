
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant76JobVariant4Provider
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
    public static class UserEventPayloadVariant76JobVariant4ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant76JobVariant4Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant76JobVariant4Provider.Github => "github",
                UserEventPayloadVariant76JobVariant4Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant76JobVariant4Provider.GithubLimited => "github-limited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant76JobVariant4Provider? ToEnum(string value)
        {
            return value switch
            {
                "github" => UserEventPayloadVariant76JobVariant4Provider.Github,
                "github-custom-host" => UserEventPayloadVariant76JobVariant4Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant76JobVariant4Provider.GithubLimited,
                _ => null,
            };
        }
    }
}
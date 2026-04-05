
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant270Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Apple,
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Chatgpt,
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
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant270ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant270Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant270Provider.Apple => "apple",
                UserEventPayloadVariant270Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant270Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant270Provider.Github => "github",
                UserEventPayloadVariant270Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant270Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant270Provider.Gitlab => "gitlab",
                UserEventPayloadVariant270Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant270Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant270Provider.Apple,
                "bitbucket" => UserEventPayloadVariant270Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant270Provider.Chatgpt,
                "github" => UserEventPayloadVariant270Provider.Github,
                "github-custom-host" => UserEventPayloadVariant270Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant270Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant270Provider.Gitlab,
                "google" => UserEventPayloadVariant270Provider.Google,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant281Provider
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
    public static class UserEventPayloadVariant281ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant281Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant281Provider.Apple => "apple",
                UserEventPayloadVariant281Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant281Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant281Provider.Github => "github",
                UserEventPayloadVariant281Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant281Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant281Provider.Gitlab => "gitlab",
                UserEventPayloadVariant281Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant281Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant281Provider.Apple,
                "bitbucket" => UserEventPayloadVariant281Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant281Provider.Chatgpt,
                "github" => UserEventPayloadVariant281Provider.Github,
                "github-custom-host" => UserEventPayloadVariant281Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant281Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant281Provider.Gitlab,
                "google" => UserEventPayloadVariant281Provider.Google,
                _ => null,
            };
        }
    }
}
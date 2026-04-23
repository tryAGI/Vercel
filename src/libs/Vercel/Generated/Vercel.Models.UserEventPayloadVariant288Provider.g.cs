
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant288Provider
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
    public static class UserEventPayloadVariant288ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant288Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant288Provider.Apple => "apple",
                UserEventPayloadVariant288Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant288Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant288Provider.Github => "github",
                UserEventPayloadVariant288Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant288Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant288Provider.Gitlab => "gitlab",
                UserEventPayloadVariant288Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant288Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant288Provider.Apple,
                "bitbucket" => UserEventPayloadVariant288Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant288Provider.Chatgpt,
                "github" => UserEventPayloadVariant288Provider.Github,
                "github-custom-host" => UserEventPayloadVariant288Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant288Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant288Provider.Gitlab,
                "google" => UserEventPayloadVariant288Provider.Google,
                _ => null,
            };
        }
    }
}
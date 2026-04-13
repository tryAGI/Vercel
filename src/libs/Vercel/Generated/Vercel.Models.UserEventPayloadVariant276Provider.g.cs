
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant276Provider
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
    public static class UserEventPayloadVariant276ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant276Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant276Provider.Apple => "apple",
                UserEventPayloadVariant276Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant276Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant276Provider.Github => "github",
                UserEventPayloadVariant276Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant276Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant276Provider.Gitlab => "gitlab",
                UserEventPayloadVariant276Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant276Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant276Provider.Apple,
                "bitbucket" => UserEventPayloadVariant276Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant276Provider.Chatgpt,
                "github" => UserEventPayloadVariant276Provider.Github,
                "github-custom-host" => UserEventPayloadVariant276Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant276Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant276Provider.Gitlab,
                "google" => UserEventPayloadVariant276Provider.Google,
                _ => null,
            };
        }
    }
}
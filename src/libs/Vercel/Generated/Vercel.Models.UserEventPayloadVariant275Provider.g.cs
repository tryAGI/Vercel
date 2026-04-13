
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant275Provider
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
    public static class UserEventPayloadVariant275ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant275Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant275Provider.Apple => "apple",
                UserEventPayloadVariant275Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant275Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant275Provider.Github => "github",
                UserEventPayloadVariant275Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant275Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant275Provider.Gitlab => "gitlab",
                UserEventPayloadVariant275Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant275Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant275Provider.Apple,
                "bitbucket" => UserEventPayloadVariant275Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant275Provider.Chatgpt,
                "github" => UserEventPayloadVariant275Provider.Github,
                "github-custom-host" => UserEventPayloadVariant275Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant275Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant275Provider.Gitlab,
                "google" => UserEventPayloadVariant275Provider.Google,
                _ => null,
            };
        }
    }
}
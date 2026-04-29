
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant298Provider
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
    public static class UserEventPayloadVariant298ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant298Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant298Provider.Apple => "apple",
                UserEventPayloadVariant298Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant298Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant298Provider.Github => "github",
                UserEventPayloadVariant298Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant298Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant298Provider.Gitlab => "gitlab",
                UserEventPayloadVariant298Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant298Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant298Provider.Apple,
                "bitbucket" => UserEventPayloadVariant298Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant298Provider.Chatgpt,
                "github" => UserEventPayloadVariant298Provider.Github,
                "github-custom-host" => UserEventPayloadVariant298Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant298Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant298Provider.Gitlab,
                "google" => UserEventPayloadVariant298Provider.Google,
                _ => null,
            };
        }
    }
}
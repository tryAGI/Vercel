
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant299Provider
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
    public static class UserEventPayloadVariant299ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant299Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant299Provider.Apple => "apple",
                UserEventPayloadVariant299Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant299Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant299Provider.Github => "github",
                UserEventPayloadVariant299Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant299Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant299Provider.Gitlab => "gitlab",
                UserEventPayloadVariant299Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant299Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant299Provider.Apple,
                "bitbucket" => UserEventPayloadVariant299Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant299Provider.Chatgpt,
                "github" => UserEventPayloadVariant299Provider.Github,
                "github-custom-host" => UserEventPayloadVariant299Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant299Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant299Provider.Gitlab,
                "google" => UserEventPayloadVariant299Provider.Google,
                _ => null,
            };
        }
    }
}
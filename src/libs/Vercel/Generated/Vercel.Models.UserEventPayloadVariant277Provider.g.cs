
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant277Provider
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
    public static class UserEventPayloadVariant277ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant277Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant277Provider.Apple => "apple",
                UserEventPayloadVariant277Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant277Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant277Provider.Github => "github",
                UserEventPayloadVariant277Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant277Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant277Provider.Gitlab => "gitlab",
                UserEventPayloadVariant277Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant277Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant277Provider.Apple,
                "bitbucket" => UserEventPayloadVariant277Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant277Provider.Chatgpt,
                "github" => UserEventPayloadVariant277Provider.Github,
                "github-custom-host" => UserEventPayloadVariant277Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant277Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant277Provider.Gitlab,
                "google" => UserEventPayloadVariant277Provider.Google,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant286Provider
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
    public static class UserEventPayloadVariant286ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant286Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant286Provider.Apple => "apple",
                UserEventPayloadVariant286Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant286Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant286Provider.Github => "github",
                UserEventPayloadVariant286Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant286Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant286Provider.Gitlab => "gitlab",
                UserEventPayloadVariant286Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant286Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant286Provider.Apple,
                "bitbucket" => UserEventPayloadVariant286Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant286Provider.Chatgpt,
                "github" => UserEventPayloadVariant286Provider.Github,
                "github-custom-host" => UserEventPayloadVariant286Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant286Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant286Provider.Gitlab,
                "google" => UserEventPayloadVariant286Provider.Google,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant289Provider
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
    public static class UserEventPayloadVariant289ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant289Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant289Provider.Apple => "apple",
                UserEventPayloadVariant289Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant289Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant289Provider.Github => "github",
                UserEventPayloadVariant289Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant289Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant289Provider.Gitlab => "gitlab",
                UserEventPayloadVariant289Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant289Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant289Provider.Apple,
                "bitbucket" => UserEventPayloadVariant289Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant289Provider.Chatgpt,
                "github" => UserEventPayloadVariant289Provider.Github,
                "github-custom-host" => UserEventPayloadVariant289Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant289Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant289Provider.Gitlab,
                "google" => UserEventPayloadVariant289Provider.Google,
                _ => null,
            };
        }
    }
}
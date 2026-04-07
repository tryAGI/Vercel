
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant271Provider
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
    public static class UserEventPayloadVariant271ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant271Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant271Provider.Apple => "apple",
                UserEventPayloadVariant271Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant271Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant271Provider.Github => "github",
                UserEventPayloadVariant271Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant271Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant271Provider.Gitlab => "gitlab",
                UserEventPayloadVariant271Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant271Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant271Provider.Apple,
                "bitbucket" => UserEventPayloadVariant271Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant271Provider.Chatgpt,
                "github" => UserEventPayloadVariant271Provider.Github,
                "github-custom-host" => UserEventPayloadVariant271Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant271Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant271Provider.Gitlab,
                "google" => UserEventPayloadVariant271Provider.Google,
                _ => null,
            };
        }
    }
}
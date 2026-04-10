
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant273Provider
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
    public static class UserEventPayloadVariant273ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant273Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant273Provider.Apple => "apple",
                UserEventPayloadVariant273Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant273Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant273Provider.Github => "github",
                UserEventPayloadVariant273Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant273Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant273Provider.Gitlab => "gitlab",
                UserEventPayloadVariant273Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant273Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant273Provider.Apple,
                "bitbucket" => UserEventPayloadVariant273Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant273Provider.Chatgpt,
                "github" => UserEventPayloadVariant273Provider.Github,
                "github-custom-host" => UserEventPayloadVariant273Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant273Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant273Provider.Gitlab,
                "google" => UserEventPayloadVariant273Provider.Google,
                _ => null,
            };
        }
    }
}
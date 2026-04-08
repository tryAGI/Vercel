
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant272Provider
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
    public static class UserEventPayloadVariant272ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant272Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant272Provider.Apple => "apple",
                UserEventPayloadVariant272Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant272Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant272Provider.Github => "github",
                UserEventPayloadVariant272Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant272Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant272Provider.Gitlab => "gitlab",
                UserEventPayloadVariant272Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant272Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant272Provider.Apple,
                "bitbucket" => UserEventPayloadVariant272Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant272Provider.Chatgpt,
                "github" => UserEventPayloadVariant272Provider.Github,
                "github-custom-host" => UserEventPayloadVariant272Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant272Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant272Provider.Gitlab,
                "google" => UserEventPayloadVariant272Provider.Google,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant300Provider
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
    public static class UserEventPayloadVariant300ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant300Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant300Provider.Apple => "apple",
                UserEventPayloadVariant300Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant300Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant300Provider.Github => "github",
                UserEventPayloadVariant300Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant300Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant300Provider.Gitlab => "gitlab",
                UserEventPayloadVariant300Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant300Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant300Provider.Apple,
                "bitbucket" => UserEventPayloadVariant300Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant300Provider.Chatgpt,
                "github" => UserEventPayloadVariant300Provider.Github,
                "github-custom-host" => UserEventPayloadVariant300Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant300Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant300Provider.Gitlab,
                "google" => UserEventPayloadVariant300Provider.Google,
                _ => null,
            };
        }
    }
}
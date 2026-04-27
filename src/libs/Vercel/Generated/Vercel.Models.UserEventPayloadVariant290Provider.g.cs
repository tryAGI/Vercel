
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant290Provider
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
    public static class UserEventPayloadVariant290ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant290Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant290Provider.Apple => "apple",
                UserEventPayloadVariant290Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant290Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant290Provider.Github => "github",
                UserEventPayloadVariant290Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant290Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant290Provider.Gitlab => "gitlab",
                UserEventPayloadVariant290Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant290Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant290Provider.Apple,
                "bitbucket" => UserEventPayloadVariant290Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant290Provider.Chatgpt,
                "github" => UserEventPayloadVariant290Provider.Github,
                "github-custom-host" => UserEventPayloadVariant290Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant290Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant290Provider.Gitlab,
                "google" => UserEventPayloadVariant290Provider.Google,
                _ => null,
            };
        }
    }
}
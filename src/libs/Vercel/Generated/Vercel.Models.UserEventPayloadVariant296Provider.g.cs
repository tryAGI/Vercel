
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant296Provider
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
    public static class UserEventPayloadVariant296ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant296Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant296Provider.Apple => "apple",
                UserEventPayloadVariant296Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant296Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant296Provider.Github => "github",
                UserEventPayloadVariant296Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant296Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant296Provider.Gitlab => "gitlab",
                UserEventPayloadVariant296Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant296Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant296Provider.Apple,
                "bitbucket" => UserEventPayloadVariant296Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant296Provider.Chatgpt,
                "github" => UserEventPayloadVariant296Provider.Github,
                "github-custom-host" => UserEventPayloadVariant296Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant296Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant296Provider.Gitlab,
                "google" => UserEventPayloadVariant296Provider.Google,
                _ => null,
            };
        }
    }
}
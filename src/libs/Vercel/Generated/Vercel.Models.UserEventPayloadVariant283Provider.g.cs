
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant283Provider
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
    public static class UserEventPayloadVariant283ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant283Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant283Provider.Apple => "apple",
                UserEventPayloadVariant283Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant283Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant283Provider.Github => "github",
                UserEventPayloadVariant283Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant283Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant283Provider.Gitlab => "gitlab",
                UserEventPayloadVariant283Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant283Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant283Provider.Apple,
                "bitbucket" => UserEventPayloadVariant283Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant283Provider.Chatgpt,
                "github" => UserEventPayloadVariant283Provider.Github,
                "github-custom-host" => UserEventPayloadVariant283Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant283Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant283Provider.Gitlab,
                "google" => UserEventPayloadVariant283Provider.Google,
                _ => null,
            };
        }
    }
}
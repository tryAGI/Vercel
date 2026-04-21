
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant284Provider
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
    public static class UserEventPayloadVariant284ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant284Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant284Provider.Apple => "apple",
                UserEventPayloadVariant284Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant284Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant284Provider.Github => "github",
                UserEventPayloadVariant284Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant284Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant284Provider.Gitlab => "gitlab",
                UserEventPayloadVariant284Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant284Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant284Provider.Apple,
                "bitbucket" => UserEventPayloadVariant284Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant284Provider.Chatgpt,
                "github" => UserEventPayloadVariant284Provider.Github,
                "github-custom-host" => UserEventPayloadVariant284Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant284Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant284Provider.Gitlab,
                "google" => UserEventPayloadVariant284Provider.Google,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant274Provider
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
    public static class UserEventPayloadVariant274ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant274Provider value)
        {
            return value switch
            {
                UserEventPayloadVariant274Provider.Apple => "apple",
                UserEventPayloadVariant274Provider.Bitbucket => "bitbucket",
                UserEventPayloadVariant274Provider.Chatgpt => "chatgpt",
                UserEventPayloadVariant274Provider.Github => "github",
                UserEventPayloadVariant274Provider.GithubCustomHost => "github-custom-host",
                UserEventPayloadVariant274Provider.GithubLimited => "github-limited",
                UserEventPayloadVariant274Provider.Gitlab => "gitlab",
                UserEventPayloadVariant274Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant274Provider? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant274Provider.Apple,
                "bitbucket" => UserEventPayloadVariant274Provider.Bitbucket,
                "chatgpt" => UserEventPayloadVariant274Provider.Chatgpt,
                "github" => UserEventPayloadVariant274Provider.Github,
                "github-custom-host" => UserEventPayloadVariant274Provider.GithubCustomHost,
                "github-limited" => UserEventPayloadVariant274Provider.GithubLimited,
                "gitlab" => UserEventPayloadVariant274Provider.Gitlab,
                "google" => UserEventPayloadVariant274Provider.Google,
                _ => null,
            };
        }
    }
}
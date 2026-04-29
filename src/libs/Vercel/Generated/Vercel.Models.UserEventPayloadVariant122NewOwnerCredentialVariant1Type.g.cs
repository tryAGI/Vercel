
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerCredentialVariant1Type
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
        GithubOauth,
        /// <summary>
        /// 
        /// </summary>
        GithubOauthLimited,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant122NewOwnerCredentialVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerCredentialVariant1Type value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerCredentialVariant1Type.Apple => "apple",
                UserEventPayloadVariant122NewOwnerCredentialVariant1Type.Bitbucket => "bitbucket",
                UserEventPayloadVariant122NewOwnerCredentialVariant1Type.Chatgpt => "chatgpt",
                UserEventPayloadVariant122NewOwnerCredentialVariant1Type.GithubOauth => "github-oauth",
                UserEventPayloadVariant122NewOwnerCredentialVariant1Type.GithubOauthLimited => "github-oauth-limited",
                UserEventPayloadVariant122NewOwnerCredentialVariant1Type.Gitlab => "gitlab",
                UserEventPayloadVariant122NewOwnerCredentialVariant1Type.Google => "google",
                UserEventPayloadVariant122NewOwnerCredentialVariant1Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerCredentialVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant122NewOwnerCredentialVariant1Type.Apple,
                "bitbucket" => UserEventPayloadVariant122NewOwnerCredentialVariant1Type.Bitbucket,
                "chatgpt" => UserEventPayloadVariant122NewOwnerCredentialVariant1Type.Chatgpt,
                "github-oauth" => UserEventPayloadVariant122NewOwnerCredentialVariant1Type.GithubOauth,
                "github-oauth-limited" => UserEventPayloadVariant122NewOwnerCredentialVariant1Type.GithubOauthLimited,
                "gitlab" => UserEventPayloadVariant122NewOwnerCredentialVariant1Type.Gitlab,
                "google" => UserEventPayloadVariant122NewOwnerCredentialVariant1Type.Google,
                "vercel" => UserEventPayloadVariant122NewOwnerCredentialVariant1Type.Vercel,
                _ => null,
            };
        }
    }
}
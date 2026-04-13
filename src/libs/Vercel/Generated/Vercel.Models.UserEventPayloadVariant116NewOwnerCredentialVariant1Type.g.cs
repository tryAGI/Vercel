
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerCredentialVariant1Type
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
    public static class UserEventPayloadVariant116NewOwnerCredentialVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerCredentialVariant1Type value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerCredentialVariant1Type.Apple => "apple",
                UserEventPayloadVariant116NewOwnerCredentialVariant1Type.Bitbucket => "bitbucket",
                UserEventPayloadVariant116NewOwnerCredentialVariant1Type.Chatgpt => "chatgpt",
                UserEventPayloadVariant116NewOwnerCredentialVariant1Type.GithubOauth => "github-oauth",
                UserEventPayloadVariant116NewOwnerCredentialVariant1Type.GithubOauthLimited => "github-oauth-limited",
                UserEventPayloadVariant116NewOwnerCredentialVariant1Type.Gitlab => "gitlab",
                UserEventPayloadVariant116NewOwnerCredentialVariant1Type.Google => "google",
                UserEventPayloadVariant116NewOwnerCredentialVariant1Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerCredentialVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant116NewOwnerCredentialVariant1Type.Apple,
                "bitbucket" => UserEventPayloadVariant116NewOwnerCredentialVariant1Type.Bitbucket,
                "chatgpt" => UserEventPayloadVariant116NewOwnerCredentialVariant1Type.Chatgpt,
                "github-oauth" => UserEventPayloadVariant116NewOwnerCredentialVariant1Type.GithubOauth,
                "github-oauth-limited" => UserEventPayloadVariant116NewOwnerCredentialVariant1Type.GithubOauthLimited,
                "gitlab" => UserEventPayloadVariant116NewOwnerCredentialVariant1Type.Gitlab,
                "google" => UserEventPayloadVariant116NewOwnerCredentialVariant1Type.Google,
                "vercel" => UserEventPayloadVariant116NewOwnerCredentialVariant1Type.Vercel,
                _ => null,
            };
        }
    }
}
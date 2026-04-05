
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerCredentialVariant1Type
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
    public static class UserEventPayloadVariant114NewOwnerCredentialVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerCredentialVariant1Type value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerCredentialVariant1Type.Apple => "apple",
                UserEventPayloadVariant114NewOwnerCredentialVariant1Type.Bitbucket => "bitbucket",
                UserEventPayloadVariant114NewOwnerCredentialVariant1Type.Chatgpt => "chatgpt",
                UserEventPayloadVariant114NewOwnerCredentialVariant1Type.GithubOauth => "github-oauth",
                UserEventPayloadVariant114NewOwnerCredentialVariant1Type.GithubOauthLimited => "github-oauth-limited",
                UserEventPayloadVariant114NewOwnerCredentialVariant1Type.Gitlab => "gitlab",
                UserEventPayloadVariant114NewOwnerCredentialVariant1Type.Google => "google",
                UserEventPayloadVariant114NewOwnerCredentialVariant1Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerCredentialVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant114NewOwnerCredentialVariant1Type.Apple,
                "bitbucket" => UserEventPayloadVariant114NewOwnerCredentialVariant1Type.Bitbucket,
                "chatgpt" => UserEventPayloadVariant114NewOwnerCredentialVariant1Type.Chatgpt,
                "github-oauth" => UserEventPayloadVariant114NewOwnerCredentialVariant1Type.GithubOauth,
                "github-oauth-limited" => UserEventPayloadVariant114NewOwnerCredentialVariant1Type.GithubOauthLimited,
                "gitlab" => UserEventPayloadVariant114NewOwnerCredentialVariant1Type.Gitlab,
                "google" => UserEventPayloadVariant114NewOwnerCredentialVariant1Type.Google,
                "vercel" => UserEventPayloadVariant114NewOwnerCredentialVariant1Type.Vercel,
                _ => null,
            };
        }
    }
}
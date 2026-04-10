
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerCredentialVariant1Type
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
    public static class UserEventPayloadVariant115NewOwnerCredentialVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerCredentialVariant1Type value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerCredentialVariant1Type.Apple => "apple",
                UserEventPayloadVariant115NewOwnerCredentialVariant1Type.Bitbucket => "bitbucket",
                UserEventPayloadVariant115NewOwnerCredentialVariant1Type.Chatgpt => "chatgpt",
                UserEventPayloadVariant115NewOwnerCredentialVariant1Type.GithubOauth => "github-oauth",
                UserEventPayloadVariant115NewOwnerCredentialVariant1Type.GithubOauthLimited => "github-oauth-limited",
                UserEventPayloadVariant115NewOwnerCredentialVariant1Type.Gitlab => "gitlab",
                UserEventPayloadVariant115NewOwnerCredentialVariant1Type.Google => "google",
                UserEventPayloadVariant115NewOwnerCredentialVariant1Type.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerCredentialVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "apple" => UserEventPayloadVariant115NewOwnerCredentialVariant1Type.Apple,
                "bitbucket" => UserEventPayloadVariant115NewOwnerCredentialVariant1Type.Bitbucket,
                "chatgpt" => UserEventPayloadVariant115NewOwnerCredentialVariant1Type.Chatgpt,
                "github-oauth" => UserEventPayloadVariant115NewOwnerCredentialVariant1Type.GithubOauth,
                "github-oauth-limited" => UserEventPayloadVariant115NewOwnerCredentialVariant1Type.GithubOauthLimited,
                "gitlab" => UserEventPayloadVariant115NewOwnerCredentialVariant1Type.Gitlab,
                "google" => UserEventPayloadVariant115NewOwnerCredentialVariant1Type.Google,
                "vercel" => UserEventPayloadVariant115NewOwnerCredentialVariant1Type.Vercel,
                _ => null,
            };
        }
    }
}
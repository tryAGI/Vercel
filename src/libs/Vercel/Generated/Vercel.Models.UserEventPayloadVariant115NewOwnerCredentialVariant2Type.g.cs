
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerCredentialVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        GithubOauthCustomHost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant115NewOwnerCredentialVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerCredentialVariant2Type value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerCredentialVariant2Type.GithubOauthCustomHost => "github-oauth-custom-host",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerCredentialVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "github-oauth-custom-host" => UserEventPayloadVariant115NewOwnerCredentialVariant2Type.GithubOauthCustomHost,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant315AppClientAuthenticationUsedMethod
    {
        /// <summary>
        /// 
        /// </summary>
        ClientSecretBasic,
        /// <summary>
        /// 
        /// </summary>
        ClientSecretJwt,
        /// <summary>
        /// 
        /// </summary>
        ClientSecretPost,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        OidcToken,
        /// <summary>
        /// 
        /// </summary>
        PrivateKeyJwt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant315AppClientAuthenticationUsedMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant315AppClientAuthenticationUsedMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant315AppClientAuthenticationUsedMethod.ClientSecretBasic => "client_secret_basic",
                UserEventPayloadVariant315AppClientAuthenticationUsedMethod.ClientSecretJwt => "client_secret_jwt",
                UserEventPayloadVariant315AppClientAuthenticationUsedMethod.ClientSecretPost => "client_secret_post",
                UserEventPayloadVariant315AppClientAuthenticationUsedMethod.None => "none",
                UserEventPayloadVariant315AppClientAuthenticationUsedMethod.OidcToken => "oidc_token",
                UserEventPayloadVariant315AppClientAuthenticationUsedMethod.PrivateKeyJwt => "private_key_jwt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant315AppClientAuthenticationUsedMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => UserEventPayloadVariant315AppClientAuthenticationUsedMethod.ClientSecretBasic,
                "client_secret_jwt" => UserEventPayloadVariant315AppClientAuthenticationUsedMethod.ClientSecretJwt,
                "client_secret_post" => UserEventPayloadVariant315AppClientAuthenticationUsedMethod.ClientSecretPost,
                "none" => UserEventPayloadVariant315AppClientAuthenticationUsedMethod.None,
                "oidc_token" => UserEventPayloadVariant315AppClientAuthenticationUsedMethod.OidcToken,
                "private_key_jwt" => UserEventPayloadVariant315AppClientAuthenticationUsedMethod.PrivateKeyJwt,
                _ => null,
            };
        }
    }
}
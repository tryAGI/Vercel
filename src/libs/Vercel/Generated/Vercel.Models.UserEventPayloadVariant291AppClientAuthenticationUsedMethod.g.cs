
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant291AppClientAuthenticationUsedMethod
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
    public static class UserEventPayloadVariant291AppClientAuthenticationUsedMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant291AppClientAuthenticationUsedMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant291AppClientAuthenticationUsedMethod.ClientSecretBasic => "client_secret_basic",
                UserEventPayloadVariant291AppClientAuthenticationUsedMethod.ClientSecretJwt => "client_secret_jwt",
                UserEventPayloadVariant291AppClientAuthenticationUsedMethod.ClientSecretPost => "client_secret_post",
                UserEventPayloadVariant291AppClientAuthenticationUsedMethod.None => "none",
                UserEventPayloadVariant291AppClientAuthenticationUsedMethod.OidcToken => "oidc_token",
                UserEventPayloadVariant291AppClientAuthenticationUsedMethod.PrivateKeyJwt => "private_key_jwt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant291AppClientAuthenticationUsedMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => UserEventPayloadVariant291AppClientAuthenticationUsedMethod.ClientSecretBasic,
                "client_secret_jwt" => UserEventPayloadVariant291AppClientAuthenticationUsedMethod.ClientSecretJwt,
                "client_secret_post" => UserEventPayloadVariant291AppClientAuthenticationUsedMethod.ClientSecretPost,
                "none" => UserEventPayloadVariant291AppClientAuthenticationUsedMethod.None,
                "oidc_token" => UserEventPayloadVariant291AppClientAuthenticationUsedMethod.OidcToken,
                "private_key_jwt" => UserEventPayloadVariant291AppClientAuthenticationUsedMethod.PrivateKeyJwt,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant290AppClientAuthenticationUsedMethod
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
    public static class UserEventPayloadVariant290AppClientAuthenticationUsedMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant290AppClientAuthenticationUsedMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant290AppClientAuthenticationUsedMethod.ClientSecretBasic => "client_secret_basic",
                UserEventPayloadVariant290AppClientAuthenticationUsedMethod.ClientSecretJwt => "client_secret_jwt",
                UserEventPayloadVariant290AppClientAuthenticationUsedMethod.ClientSecretPost => "client_secret_post",
                UserEventPayloadVariant290AppClientAuthenticationUsedMethod.None => "none",
                UserEventPayloadVariant290AppClientAuthenticationUsedMethod.OidcToken => "oidc_token",
                UserEventPayloadVariant290AppClientAuthenticationUsedMethod.PrivateKeyJwt => "private_key_jwt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant290AppClientAuthenticationUsedMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => UserEventPayloadVariant290AppClientAuthenticationUsedMethod.ClientSecretBasic,
                "client_secret_jwt" => UserEventPayloadVariant290AppClientAuthenticationUsedMethod.ClientSecretJwt,
                "client_secret_post" => UserEventPayloadVariant290AppClientAuthenticationUsedMethod.ClientSecretPost,
                "none" => UserEventPayloadVariant290AppClientAuthenticationUsedMethod.None,
                "oidc_token" => UserEventPayloadVariant290AppClientAuthenticationUsedMethod.OidcToken,
                "private_key_jwt" => UserEventPayloadVariant290AppClientAuthenticationUsedMethod.PrivateKeyJwt,
                _ => null,
            };
        }
    }
}
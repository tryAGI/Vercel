
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant309AppClientAuthenticationUsedMethod
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
    public static class UserEventPayloadVariant309AppClientAuthenticationUsedMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant309AppClientAuthenticationUsedMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant309AppClientAuthenticationUsedMethod.ClientSecretBasic => "client_secret_basic",
                UserEventPayloadVariant309AppClientAuthenticationUsedMethod.ClientSecretJwt => "client_secret_jwt",
                UserEventPayloadVariant309AppClientAuthenticationUsedMethod.ClientSecretPost => "client_secret_post",
                UserEventPayloadVariant309AppClientAuthenticationUsedMethod.None => "none",
                UserEventPayloadVariant309AppClientAuthenticationUsedMethod.OidcToken => "oidc_token",
                UserEventPayloadVariant309AppClientAuthenticationUsedMethod.PrivateKeyJwt => "private_key_jwt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant309AppClientAuthenticationUsedMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => UserEventPayloadVariant309AppClientAuthenticationUsedMethod.ClientSecretBasic,
                "client_secret_jwt" => UserEventPayloadVariant309AppClientAuthenticationUsedMethod.ClientSecretJwt,
                "client_secret_post" => UserEventPayloadVariant309AppClientAuthenticationUsedMethod.ClientSecretPost,
                "none" => UserEventPayloadVariant309AppClientAuthenticationUsedMethod.None,
                "oidc_token" => UserEventPayloadVariant309AppClientAuthenticationUsedMethod.OidcToken,
                "private_key_jwt" => UserEventPayloadVariant309AppClientAuthenticationUsedMethod.PrivateKeyJwt,
                _ => null,
            };
        }
    }
}
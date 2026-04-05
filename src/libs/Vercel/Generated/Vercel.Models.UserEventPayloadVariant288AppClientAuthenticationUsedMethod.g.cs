
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant288AppClientAuthenticationUsedMethod
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
    public static class UserEventPayloadVariant288AppClientAuthenticationUsedMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant288AppClientAuthenticationUsedMethod value)
        {
            return value switch
            {
                UserEventPayloadVariant288AppClientAuthenticationUsedMethod.ClientSecretBasic => "client_secret_basic",
                UserEventPayloadVariant288AppClientAuthenticationUsedMethod.ClientSecretJwt => "client_secret_jwt",
                UserEventPayloadVariant288AppClientAuthenticationUsedMethod.ClientSecretPost => "client_secret_post",
                UserEventPayloadVariant288AppClientAuthenticationUsedMethod.None => "none",
                UserEventPayloadVariant288AppClientAuthenticationUsedMethod.OidcToken => "oidc_token",
                UserEventPayloadVariant288AppClientAuthenticationUsedMethod.PrivateKeyJwt => "private_key_jwt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant288AppClientAuthenticationUsedMethod? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => UserEventPayloadVariant288AppClientAuthenticationUsedMethod.ClientSecretBasic,
                "client_secret_jwt" => UserEventPayloadVariant288AppClientAuthenticationUsedMethod.ClientSecretJwt,
                "client_secret_post" => UserEventPayloadVariant288AppClientAuthenticationUsedMethod.ClientSecretPost,
                "none" => UserEventPayloadVariant288AppClientAuthenticationUsedMethod.None,
                "oidc_token" => UserEventPayloadVariant288AppClientAuthenticationUsedMethod.OidcToken,
                "private_key_jwt" => UserEventPayloadVariant288AppClientAuthenticationUsedMethod.PrivateKeyJwt,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant299GrantType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationCode,
        /// <summary>
        /// 
        /// </summary>
        Urn_ietf_params_oauth_grantType_deviceCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant299GrantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant299GrantType value)
        {
            return value switch
            {
                UserEventPayloadVariant299GrantType.AuthorizationCode => "authorization_code",
                UserEventPayloadVariant299GrantType.Urn_ietf_params_oauth_grantType_deviceCode => "urn:ietf:params:oauth:grant-type:device_code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant299GrantType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_code" => UserEventPayloadVariant299GrantType.AuthorizationCode,
                "urn:ietf:params:oauth:grant-type:device_code" => UserEventPayloadVariant299GrantType.Urn_ietf_params_oauth_grantType_deviceCode,
                _ => null,
            };
        }
    }
}
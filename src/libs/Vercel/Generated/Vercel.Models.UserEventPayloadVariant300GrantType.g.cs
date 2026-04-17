
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant300GrantType
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
    public static class UserEventPayloadVariant300GrantTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant300GrantType value)
        {
            return value switch
            {
                UserEventPayloadVariant300GrantType.AuthorizationCode => "authorization_code",
                UserEventPayloadVariant300GrantType.Urn_ietf_params_oauth_grantType_deviceCode => "urn:ietf:params:oauth:grant-type:device_code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant300GrantType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_code" => UserEventPayloadVariant300GrantType.AuthorizationCode,
                "urn:ietf:params:oauth:grant-type:device_code" => UserEventPayloadVariant300GrantType.Urn_ietf_params_oauth_grantType_deviceCode,
                _ => null,
            };
        }
    }
}
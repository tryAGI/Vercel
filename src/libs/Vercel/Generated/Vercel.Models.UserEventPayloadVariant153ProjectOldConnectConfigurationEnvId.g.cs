
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant153ProjectOldConnectConfigurationEnvId
    {
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant153ProjectOldConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant153ProjectOldConnectConfigurationEnvId value)
        {
            return value switch
            {
                UserEventPayloadVariant153ProjectOldConnectConfigurationEnvId.Preview => "preview",
                UserEventPayloadVariant153ProjectOldConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant153ProjectOldConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant153ProjectOldConnectConfigurationEnvId.Preview,
                "production" => UserEventPayloadVariant153ProjectOldConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
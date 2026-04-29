
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant168ProjectOldConnectConfigurationEnvId
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
    public static class UserEventPayloadVariant168ProjectOldConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant168ProjectOldConnectConfigurationEnvId value)
        {
            return value switch
            {
                UserEventPayloadVariant168ProjectOldConnectConfigurationEnvId.Preview => "preview",
                UserEventPayloadVariant168ProjectOldConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant168ProjectOldConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant168ProjectOldConnectConfigurationEnvId.Preview,
                "production" => UserEventPayloadVariant168ProjectOldConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
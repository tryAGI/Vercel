
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant152ProjectOldConnectConfigurationEnvId
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
    public static class UserEventPayloadVariant152ProjectOldConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant152ProjectOldConnectConfigurationEnvId value)
        {
            return value switch
            {
                UserEventPayloadVariant152ProjectOldConnectConfigurationEnvId.Preview => "preview",
                UserEventPayloadVariant152ProjectOldConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant152ProjectOldConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant152ProjectOldConnectConfigurationEnvId.Preview,
                "production" => UserEventPayloadVariant152ProjectOldConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
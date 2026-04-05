
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant151ProjectOldConnectConfigurationEnvId
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
    public static class UserEventPayloadVariant151ProjectOldConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant151ProjectOldConnectConfigurationEnvId value)
        {
            return value switch
            {
                UserEventPayloadVariant151ProjectOldConnectConfigurationEnvId.Preview => "preview",
                UserEventPayloadVariant151ProjectOldConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant151ProjectOldConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant151ProjectOldConnectConfigurationEnvId.Preview,
                "production" => UserEventPayloadVariant151ProjectOldConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
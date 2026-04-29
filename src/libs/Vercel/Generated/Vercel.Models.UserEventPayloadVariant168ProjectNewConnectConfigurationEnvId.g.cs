
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant168ProjectNewConnectConfigurationEnvId
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
    public static class UserEventPayloadVariant168ProjectNewConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant168ProjectNewConnectConfigurationEnvId value)
        {
            return value switch
            {
                UserEventPayloadVariant168ProjectNewConnectConfigurationEnvId.Preview => "preview",
                UserEventPayloadVariant168ProjectNewConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant168ProjectNewConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant168ProjectNewConnectConfigurationEnvId.Preview,
                "production" => UserEventPayloadVariant168ProjectNewConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
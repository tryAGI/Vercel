
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant154ProjectNewConnectConfigurationEnvId
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
    public static class UserEventPayloadVariant154ProjectNewConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant154ProjectNewConnectConfigurationEnvId value)
        {
            return value switch
            {
                UserEventPayloadVariant154ProjectNewConnectConfigurationEnvId.Preview => "preview",
                UserEventPayloadVariant154ProjectNewConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant154ProjectNewConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant154ProjectNewConnectConfigurationEnvId.Preview,
                "production" => UserEventPayloadVariant154ProjectNewConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
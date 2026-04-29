
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant166ProjectNewConnectConfigurationEnvId
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
    public static class UserEventPayloadVariant166ProjectNewConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant166ProjectNewConnectConfigurationEnvId value)
        {
            return value switch
            {
                UserEventPayloadVariant166ProjectNewConnectConfigurationEnvId.Preview => "preview",
                UserEventPayloadVariant166ProjectNewConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant166ProjectNewConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant166ProjectNewConnectConfigurationEnvId.Preview,
                "production" => UserEventPayloadVariant166ProjectNewConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
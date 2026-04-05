
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant151ProjectNewConnectConfigurationEnvId
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
    public static class UserEventPayloadVariant151ProjectNewConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant151ProjectNewConnectConfigurationEnvId value)
        {
            return value switch
            {
                UserEventPayloadVariant151ProjectNewConnectConfigurationEnvId.Preview => "preview",
                UserEventPayloadVariant151ProjectNewConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant151ProjectNewConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant151ProjectNewConnectConfigurationEnvId.Preview,
                "production" => UserEventPayloadVariant151ProjectNewConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
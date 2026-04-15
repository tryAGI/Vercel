
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant157ProjectNewConnectConfigurationEnvId
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
    public static class UserEventPayloadVariant157ProjectNewConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant157ProjectNewConnectConfigurationEnvId value)
        {
            return value switch
            {
                UserEventPayloadVariant157ProjectNewConnectConfigurationEnvId.Preview => "preview",
                UserEventPayloadVariant157ProjectNewConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant157ProjectNewConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant157ProjectNewConnectConfigurationEnvId.Preview,
                "production" => UserEventPayloadVariant157ProjectNewConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
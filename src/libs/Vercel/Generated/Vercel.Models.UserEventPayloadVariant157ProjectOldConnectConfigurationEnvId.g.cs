
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant157ProjectOldConnectConfigurationEnvId
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
    public static class UserEventPayloadVariant157ProjectOldConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant157ProjectOldConnectConfigurationEnvId value)
        {
            return value switch
            {
                UserEventPayloadVariant157ProjectOldConnectConfigurationEnvId.Preview => "preview",
                UserEventPayloadVariant157ProjectOldConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant157ProjectOldConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant157ProjectOldConnectConfigurationEnvId.Preview,
                "production" => UserEventPayloadVariant157ProjectOldConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
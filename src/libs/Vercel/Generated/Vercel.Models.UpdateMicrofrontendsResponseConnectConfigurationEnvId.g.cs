
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseConnectConfigurationEnvId
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
    public static class UpdateMicrofrontendsResponseConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseConnectConfigurationEnvId value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseConnectConfigurationEnvId.Preview => "preview",
                UpdateMicrofrontendsResponseConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateMicrofrontendsResponseConnectConfigurationEnvId.Preview,
                "production" => UpdateMicrofrontendsResponseConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
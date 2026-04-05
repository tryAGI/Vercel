
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseConnectConfigurationEnvId
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
    public static class UpdateProjectResponseConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseConnectConfigurationEnvId value)
        {
            return value switch
            {
                UpdateProjectResponseConnectConfigurationEnvId.Preview => "preview",
                UpdateProjectResponseConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UpdateProjectResponseConnectConfigurationEnvId.Preview,
                "production" => UpdateProjectResponseConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
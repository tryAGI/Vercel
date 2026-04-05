
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseConnectConfigurationEnvId
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
    public static class CreateProjectResponseConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseConnectConfigurationEnvId value)
        {
            return value switch
            {
                CreateProjectResponseConnectConfigurationEnvId.Preview => "preview",
                CreateProjectResponseConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => CreateProjectResponseConnectConfigurationEnvId.Preview,
                "production" => CreateProjectResponseConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
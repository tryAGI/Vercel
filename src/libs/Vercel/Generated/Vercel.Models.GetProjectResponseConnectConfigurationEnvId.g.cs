
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseConnectConfigurationEnvId
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
    public static class GetProjectResponseConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseConnectConfigurationEnvId value)
        {
            return value switch
            {
                GetProjectResponseConnectConfigurationEnvId.Preview => "preview",
                GetProjectResponseConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectResponseConnectConfigurationEnvId.Preview,
                "production" => GetProjectResponseConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
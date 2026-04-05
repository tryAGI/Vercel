
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectConnectConfigurationEnvId
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
    public static class GetProjectsResponseVariant3ProjectConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectConnectConfigurationEnvId value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectConnectConfigurationEnvId.Preview => "preview",
                GetProjectsResponseVariant3ProjectConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetProjectsResponseVariant3ProjectConnectConfigurationEnvId.Preview,
                "production" => GetProjectsResponseVariant3ProjectConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
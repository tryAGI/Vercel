
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectConnectConfigurationEnvId
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
    public static class GetMicrofrontendsInGroupResponseProjectConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectConnectConfigurationEnvId value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectConnectConfigurationEnvId.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetMicrofrontendsInGroupResponseProjectConnectConfigurationEnvId.Preview,
                "production" => GetMicrofrontendsInGroupResponseProjectConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
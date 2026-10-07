
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared223443184387411fConnectConfigurationEnvId
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
    public static class AutoSDKShared223443184387411fConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared223443184387411fConnectConfigurationEnvId value)
        {
            return value switch
            {
                AutoSDKShared223443184387411fConnectConfigurationEnvId.Preview => "preview",
                AutoSDKShared223443184387411fConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared223443184387411fConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared223443184387411fConnectConfigurationEnvId.Preview,
                "production" => AutoSDKShared223443184387411fConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
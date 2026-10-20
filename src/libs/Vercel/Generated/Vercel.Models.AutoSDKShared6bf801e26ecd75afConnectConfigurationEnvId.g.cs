
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afConnectConfigurationEnvId
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
    public static class AutoSDKShared6bf801e26ecd75afConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afConnectConfigurationEnvId value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afConnectConfigurationEnvId.Preview => "preview",
                AutoSDKShared6bf801e26ecd75afConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared6bf801e26ecd75afConnectConfigurationEnvId.Preview,
                "production" => AutoSDKShared6bf801e26ecd75afConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
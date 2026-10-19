
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373ConnectConfigurationEnvId
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
    public static class AutoSDKShared94b26a5607c7a373ConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373ConnectConfigurationEnvId value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373ConnectConfigurationEnvId.Preview => "preview",
                AutoSDKShared94b26a5607c7a373ConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373ConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared94b26a5607c7a373ConnectConfigurationEnvId.Preview,
                "production" => AutoSDKShared94b26a5607c7a373ConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
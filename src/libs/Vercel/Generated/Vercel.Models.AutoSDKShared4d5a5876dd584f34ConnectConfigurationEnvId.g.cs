
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared4d5a5876dd584f34ConnectConfigurationEnvId
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
    public static class AutoSDKShared4d5a5876dd584f34ConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared4d5a5876dd584f34ConnectConfigurationEnvId value)
        {
            return value switch
            {
                AutoSDKShared4d5a5876dd584f34ConnectConfigurationEnvId.Preview => "preview",
                AutoSDKShared4d5a5876dd584f34ConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared4d5a5876dd584f34ConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared4d5a5876dd584f34ConnectConfigurationEnvId.Preview,
                "production" => AutoSDKShared4d5a5876dd584f34ConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
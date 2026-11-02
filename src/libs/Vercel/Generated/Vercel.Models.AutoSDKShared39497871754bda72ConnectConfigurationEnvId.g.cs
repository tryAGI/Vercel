
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39497871754bda72ConnectConfigurationEnvId
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
    public static class AutoSDKShared39497871754bda72ConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39497871754bda72ConnectConfigurationEnvId value)
        {
            return value switch
            {
                AutoSDKShared39497871754bda72ConnectConfigurationEnvId.Preview => "preview",
                AutoSDKShared39497871754bda72ConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39497871754bda72ConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared39497871754bda72ConnectConfigurationEnvId.Preview,
                "production" => AutoSDKShared39497871754bda72ConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
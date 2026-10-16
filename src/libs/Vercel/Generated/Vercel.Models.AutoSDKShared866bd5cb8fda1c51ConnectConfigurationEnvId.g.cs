
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared866bd5cb8fda1c51ConnectConfigurationEnvId
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
    public static class AutoSDKShared866bd5cb8fda1c51ConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared866bd5cb8fda1c51ConnectConfigurationEnvId value)
        {
            return value switch
            {
                AutoSDKShared866bd5cb8fda1c51ConnectConfigurationEnvId.Preview => "preview",
                AutoSDKShared866bd5cb8fda1c51ConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared866bd5cb8fda1c51ConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared866bd5cb8fda1c51ConnectConfigurationEnvId.Preview,
                "production" => AutoSDKShared866bd5cb8fda1c51ConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
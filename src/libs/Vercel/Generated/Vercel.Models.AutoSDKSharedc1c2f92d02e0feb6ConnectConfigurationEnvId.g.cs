
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6ConnectConfigurationEnvId
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
    public static class AutoSDKSharedc1c2f92d02e0feb6ConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6ConnectConfigurationEnvId value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6ConnectConfigurationEnvId.Preview => "preview",
                AutoSDKSharedc1c2f92d02e0feb6ConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6ConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKSharedc1c2f92d02e0feb6ConnectConfigurationEnvId.Preview,
                "production" => AutoSDKSharedc1c2f92d02e0feb6ConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
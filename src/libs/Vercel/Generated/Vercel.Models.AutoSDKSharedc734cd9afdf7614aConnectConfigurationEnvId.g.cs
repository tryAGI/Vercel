
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc734cd9afdf7614aConnectConfigurationEnvId
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
    public static class AutoSDKSharedc734cd9afdf7614aConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc734cd9afdf7614aConnectConfigurationEnvId value)
        {
            return value switch
            {
                AutoSDKSharedc734cd9afdf7614aConnectConfigurationEnvId.Preview => "preview",
                AutoSDKSharedc734cd9afdf7614aConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc734cd9afdf7614aConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKSharedc734cd9afdf7614aConnectConfigurationEnvId.Preview,
                "production" => AutoSDKSharedc734cd9afdf7614aConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
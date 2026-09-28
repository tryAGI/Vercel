
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fConnectConfigurationEnvId
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
    public static class AutoSDKShareda223f19b9c37327fConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fConnectConfigurationEnvId value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fConnectConfigurationEnvId.Preview => "preview",
                AutoSDKShareda223f19b9c37327fConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShareda223f19b9c37327fConnectConfigurationEnvId.Preview,
                "production" => AutoSDKShareda223f19b9c37327fConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
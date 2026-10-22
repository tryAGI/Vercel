
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85ConnectConfigurationEnvId
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
    public static class AutoSDKShareda3889ae99195ea85ConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85ConnectConfigurationEnvId value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85ConnectConfigurationEnvId.Preview => "preview",
                AutoSDKShareda3889ae99195ea85ConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85ConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShareda3889ae99195ea85ConnectConfigurationEnvId.Preview,
                "production" => AutoSDKShareda3889ae99195ea85ConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
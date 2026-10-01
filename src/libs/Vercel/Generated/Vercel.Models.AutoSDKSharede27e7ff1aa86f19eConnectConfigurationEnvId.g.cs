
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede27e7ff1aa86f19eConnectConfigurationEnvId
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
    public static class AutoSDKSharede27e7ff1aa86f19eConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede27e7ff1aa86f19eConnectConfigurationEnvId value)
        {
            return value switch
            {
                AutoSDKSharede27e7ff1aa86f19eConnectConfigurationEnvId.Preview => "preview",
                AutoSDKSharede27e7ff1aa86f19eConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede27e7ff1aa86f19eConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKSharede27e7ff1aa86f19eConnectConfigurationEnvId.Preview,
                "production" => AutoSDKSharede27e7ff1aa86f19eConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
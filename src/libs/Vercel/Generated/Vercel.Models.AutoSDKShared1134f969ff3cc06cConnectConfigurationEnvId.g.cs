
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared1134f969ff3cc06cConnectConfigurationEnvId
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
    public static class AutoSDKShared1134f969ff3cc06cConnectConfigurationEnvIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared1134f969ff3cc06cConnectConfigurationEnvId value)
        {
            return value switch
            {
                AutoSDKShared1134f969ff3cc06cConnectConfigurationEnvId.Preview => "preview",
                AutoSDKShared1134f969ff3cc06cConnectConfigurationEnvId.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared1134f969ff3cc06cConnectConfigurationEnvId? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared1134f969ff3cc06cConnectConfigurationEnvId.Preview,
                "production" => AutoSDKShared1134f969ff3cc06cConnectConfigurationEnvId.Production,
                _ => null,
            };
        }
    }
}
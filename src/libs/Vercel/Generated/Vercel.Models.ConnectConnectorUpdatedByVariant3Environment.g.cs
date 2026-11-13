
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ConnectConnectorUpdatedByVariant3Environment
    {
        /// <summary>
        ///
        /// </summary>
        Development,
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
    public static class ConnectConnectorUpdatedByVariant3EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorUpdatedByVariant3Environment value)
        {
            return value switch
            {
                ConnectConnectorUpdatedByVariant3Environment.Development => "development",
                ConnectConnectorUpdatedByVariant3Environment.Preview => "preview",
                ConnectConnectorUpdatedByVariant3Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorUpdatedByVariant3Environment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ConnectConnectorUpdatedByVariant3Environment.Development,
                "preview" => ConnectConnectorUpdatedByVariant3Environment.Preview,
                "production" => ConnectConnectorUpdatedByVariant3Environment.Production,
                _ => null,
            };
        }
    }
}
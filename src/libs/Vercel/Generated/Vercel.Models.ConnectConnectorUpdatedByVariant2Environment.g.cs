
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ConnectConnectorUpdatedByVariant2Environment
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
    public static class ConnectConnectorUpdatedByVariant2EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorUpdatedByVariant2Environment value)
        {
            return value switch
            {
                ConnectConnectorUpdatedByVariant2Environment.Development => "development",
                ConnectConnectorUpdatedByVariant2Environment.Preview => "preview",
                ConnectConnectorUpdatedByVariant2Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorUpdatedByVariant2Environment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ConnectConnectorUpdatedByVariant2Environment.Development,
                "preview" => ConnectConnectorUpdatedByVariant2Environment.Preview,
                "production" => ConnectConnectorUpdatedByVariant2Environment.Production,
                _ => null,
            };
        }
    }
}
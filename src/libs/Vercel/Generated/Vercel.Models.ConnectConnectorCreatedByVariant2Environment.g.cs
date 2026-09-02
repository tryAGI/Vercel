
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ConnectConnectorCreatedByVariant2Environment
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
    public static class ConnectConnectorCreatedByVariant2EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreatedByVariant2Environment value)
        {
            return value switch
            {
                ConnectConnectorCreatedByVariant2Environment.Development => "development",
                ConnectConnectorCreatedByVariant2Environment.Preview => "preview",
                ConnectConnectorCreatedByVariant2Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreatedByVariant2Environment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ConnectConnectorCreatedByVariant2Environment.Development,
                "preview" => ConnectConnectorCreatedByVariant2Environment.Preview,
                "production" => ConnectConnectorCreatedByVariant2Environment.Production,
                _ => null,
            };
        }
    }
}
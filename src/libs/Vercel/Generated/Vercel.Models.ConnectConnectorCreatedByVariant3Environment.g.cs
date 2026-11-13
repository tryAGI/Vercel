
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ConnectConnectorCreatedByVariant3Environment
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
    public static class ConnectConnectorCreatedByVariant3EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreatedByVariant3Environment value)
        {
            return value switch
            {
                ConnectConnectorCreatedByVariant3Environment.Development => "development",
                ConnectConnectorCreatedByVariant3Environment.Preview => "preview",
                ConnectConnectorCreatedByVariant3Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreatedByVariant3Environment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ConnectConnectorCreatedByVariant3Environment.Development,
                "preview" => ConnectConnectorCreatedByVariant3Environment.Preview,
                "production" => ConnectConnectorCreatedByVariant3Environment.Production,
                _ => null,
            };
        }
    }
}
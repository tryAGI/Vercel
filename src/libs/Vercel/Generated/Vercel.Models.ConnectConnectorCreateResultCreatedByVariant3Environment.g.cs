
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ConnectConnectorCreateResultCreatedByVariant3Environment
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
    public static class ConnectConnectorCreateResultCreatedByVariant3EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateResultCreatedByVariant3Environment value)
        {
            return value switch
            {
                ConnectConnectorCreateResultCreatedByVariant3Environment.Development => "development",
                ConnectConnectorCreateResultCreatedByVariant3Environment.Preview => "preview",
                ConnectConnectorCreateResultCreatedByVariant3Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateResultCreatedByVariant3Environment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ConnectConnectorCreateResultCreatedByVariant3Environment.Development,
                "preview" => ConnectConnectorCreateResultCreatedByVariant3Environment.Preview,
                "production" => ConnectConnectorCreateResultCreatedByVariant3Environment.Production,
                _ => null,
            };
        }
    }
}
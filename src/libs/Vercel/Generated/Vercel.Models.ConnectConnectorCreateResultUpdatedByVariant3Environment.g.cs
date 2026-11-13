
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ConnectConnectorCreateResultUpdatedByVariant3Environment
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
    public static class ConnectConnectorCreateResultUpdatedByVariant3EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateResultUpdatedByVariant3Environment value)
        {
            return value switch
            {
                ConnectConnectorCreateResultUpdatedByVariant3Environment.Development => "development",
                ConnectConnectorCreateResultUpdatedByVariant3Environment.Preview => "preview",
                ConnectConnectorCreateResultUpdatedByVariant3Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateResultUpdatedByVariant3Environment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ConnectConnectorCreateResultUpdatedByVariant3Environment.Development,
                "preview" => ConnectConnectorCreateResultUpdatedByVariant3Environment.Preview,
                "production" => ConnectConnectorCreateResultUpdatedByVariant3Environment.Production,
                _ => null,
            };
        }
    }
}
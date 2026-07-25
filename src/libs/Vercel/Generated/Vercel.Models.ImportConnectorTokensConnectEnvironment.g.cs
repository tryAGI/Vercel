
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportConnectorTokensConnectEnvironment
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
    public static class ImportConnectorTokensConnectEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportConnectorTokensConnectEnvironment value)
        {
            return value switch
            {
                ImportConnectorTokensConnectEnvironment.Development => "development",
                ImportConnectorTokensConnectEnvironment.Preview => "preview",
                ImportConnectorTokensConnectEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportConnectorTokensConnectEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ImportConnectorTokensConnectEnvironment.Development,
                "preview" => ImportConnectorTokensConnectEnvironment.Preview,
                "production" => ImportConnectorTokensConnectEnvironment.Production,
                _ => null,
            };
        }
    }
}
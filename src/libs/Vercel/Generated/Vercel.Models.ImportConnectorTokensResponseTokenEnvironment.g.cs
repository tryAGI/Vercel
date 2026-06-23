
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportConnectorTokensResponseTokenEnvironment
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
    public static class ImportConnectorTokensResponseTokenEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportConnectorTokensResponseTokenEnvironment value)
        {
            return value switch
            {
                ImportConnectorTokensResponseTokenEnvironment.Development => "development",
                ImportConnectorTokensResponseTokenEnvironment.Preview => "preview",
                ImportConnectorTokensResponseTokenEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportConnectorTokensResponseTokenEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ImportConnectorTokensResponseTokenEnvironment.Development,
                "preview" => ImportConnectorTokensResponseTokenEnvironment.Preview,
                "production" => ImportConnectorTokensResponseTokenEnvironment.Production,
                _ => null,
            };
        }
    }
}
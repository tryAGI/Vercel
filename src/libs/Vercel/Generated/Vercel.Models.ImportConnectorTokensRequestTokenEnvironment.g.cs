
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportConnectorTokensRequestTokenEnvironment
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
    public static class ImportConnectorTokensRequestTokenEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportConnectorTokensRequestTokenEnvironment value)
        {
            return value switch
            {
                ImportConnectorTokensRequestTokenEnvironment.Development => "development",
                ImportConnectorTokensRequestTokenEnvironment.Preview => "preview",
                ImportConnectorTokensRequestTokenEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportConnectorTokensRequestTokenEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ImportConnectorTokensRequestTokenEnvironment.Development,
                "preview" => ImportConnectorTokensRequestTokenEnvironment.Preview,
                "production" => ImportConnectorTokensRequestTokenEnvironment.Production,
                _ => null,
            };
        }
    }
}
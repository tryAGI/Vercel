
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportConnectorTokensEnvironment
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
    public static class ImportConnectorTokensEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportConnectorTokensEnvironment value)
        {
            return value switch
            {
                ImportConnectorTokensEnvironment.Development => "development",
                ImportConnectorTokensEnvironment.Preview => "preview",
                ImportConnectorTokensEnvironment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportConnectorTokensEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "development" => ImportConnectorTokensEnvironment.Development,
                "preview" => ImportConnectorTokensEnvironment.Preview,
                "production" => ImportConnectorTokensEnvironment.Production,
                _ => null,
            };
        }
    }
}
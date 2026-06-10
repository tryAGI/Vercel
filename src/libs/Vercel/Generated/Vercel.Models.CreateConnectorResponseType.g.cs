
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Linear,
        /// <summary>
        /// 
        /// </summary>
        Oauth,
        /// <summary>
        /// 
        /// </summary>
        Salesforce,
        /// <summary>
        /// 
        /// </summary>
        Slack,
        /// <summary>
        /// 
        /// </summary>
        Snowflake,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorResponseType value)
        {
            return value switch
            {
                CreateConnectorResponseType.ApiKey => "api-key",
                CreateConnectorResponseType.Custom => "custom",
                CreateConnectorResponseType.Github => "github",
                CreateConnectorResponseType.Linear => "linear",
                CreateConnectorResponseType.Oauth => "oauth",
                CreateConnectorResponseType.Salesforce => "salesforce",
                CreateConnectorResponseType.Slack => "slack",
                CreateConnectorResponseType.Snowflake => "snowflake",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorResponseType? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => CreateConnectorResponseType.ApiKey,
                "custom" => CreateConnectorResponseType.Custom,
                "github" => CreateConnectorResponseType.Github,
                "linear" => CreateConnectorResponseType.Linear,
                "oauth" => CreateConnectorResponseType.Oauth,
                "salesforce" => CreateConnectorResponseType.Salesforce,
                "slack" => CreateConnectorResponseType.Slack,
                "snowflake" => CreateConnectorResponseType.Snowflake,
                _ => null,
            };
        }
    }
}
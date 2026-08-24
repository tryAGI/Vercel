
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Connector implementation type.
    /// </summary>
    public enum ConnectConnectorCreateResultType
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
        Discord,
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
        Linq,
        /// <summary>
        /// 
        /// </summary>
        MicrosoftEntra,
        /// <summary>
        /// 
        /// </summary>
        Oauth,
        /// <summary>
        /// 
        /// </summary>
        Photon,
        /// <summary>
        /// 
        /// </summary>
        Salesforce,
        /// <summary>
        /// 
        /// </summary>
        Sendblue,
        /// <summary>
        /// 
        /// </summary>
        Slack,
        /// <summary>
        /// 
        /// </summary>
        Snowflake,
        /// <summary>
        /// 
        /// </summary>
        SnowflakeWif,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreateResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateResultType value)
        {
            return value switch
            {
                ConnectConnectorCreateResultType.ApiKey => "api-key",
                ConnectConnectorCreateResultType.Custom => "custom",
                ConnectConnectorCreateResultType.Discord => "discord",
                ConnectConnectorCreateResultType.Github => "github",
                ConnectConnectorCreateResultType.Linear => "linear",
                ConnectConnectorCreateResultType.Linq => "linq",
                ConnectConnectorCreateResultType.MicrosoftEntra => "microsoft-entra",
                ConnectConnectorCreateResultType.Oauth => "oauth",
                ConnectConnectorCreateResultType.Photon => "photon",
                ConnectConnectorCreateResultType.Salesforce => "salesforce",
                ConnectConnectorCreateResultType.Sendblue => "sendblue",
                ConnectConnectorCreateResultType.Slack => "slack",
                ConnectConnectorCreateResultType.Snowflake => "snowflake",
                ConnectConnectorCreateResultType.SnowflakeWif => "snowflake-wif",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateResultType? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => ConnectConnectorCreateResultType.ApiKey,
                "custom" => ConnectConnectorCreateResultType.Custom,
                "discord" => ConnectConnectorCreateResultType.Discord,
                "github" => ConnectConnectorCreateResultType.Github,
                "linear" => ConnectConnectorCreateResultType.Linear,
                "linq" => ConnectConnectorCreateResultType.Linq,
                "microsoft-entra" => ConnectConnectorCreateResultType.MicrosoftEntra,
                "oauth" => ConnectConnectorCreateResultType.Oauth,
                "photon" => ConnectConnectorCreateResultType.Photon,
                "salesforce" => ConnectConnectorCreateResultType.Salesforce,
                "sendblue" => ConnectConnectorCreateResultType.Sendblue,
                "slack" => ConnectConnectorCreateResultType.Slack,
                "snowflake" => ConnectConnectorCreateResultType.Snowflake,
                "snowflake-wif" => ConnectConnectorCreateResultType.SnowflakeWif,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Connector implementation type.
    /// </summary>
    public enum ConnectConnectorType
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
        MicrosoftTeams,
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
    public static class ConnectConnectorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorType value)
        {
            return value switch
            {
                ConnectConnectorType.ApiKey => "api-key",
                ConnectConnectorType.Custom => "custom",
                ConnectConnectorType.Discord => "discord",
                ConnectConnectorType.Github => "github",
                ConnectConnectorType.Linear => "linear",
                ConnectConnectorType.Linq => "linq",
                ConnectConnectorType.MicrosoftEntra => "microsoft-entra",
                ConnectConnectorType.MicrosoftTeams => "microsoft-teams",
                ConnectConnectorType.Oauth => "oauth",
                ConnectConnectorType.Photon => "photon",
                ConnectConnectorType.Salesforce => "salesforce",
                ConnectConnectorType.Sendblue => "sendblue",
                ConnectConnectorType.Slack => "slack",
                ConnectConnectorType.Snowflake => "snowflake",
                ConnectConnectorType.SnowflakeWif => "snowflake-wif",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorType? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => ConnectConnectorType.ApiKey,
                "custom" => ConnectConnectorType.Custom,
                "discord" => ConnectConnectorType.Discord,
                "github" => ConnectConnectorType.Github,
                "linear" => ConnectConnectorType.Linear,
                "linq" => ConnectConnectorType.Linq,
                "microsoft-entra" => ConnectConnectorType.MicrosoftEntra,
                "microsoft-teams" => ConnectConnectorType.MicrosoftTeams,
                "oauth" => ConnectConnectorType.Oauth,
                "photon" => ConnectConnectorType.Photon,
                "salesforce" => ConnectConnectorType.Salesforce,
                "sendblue" => ConnectConnectorType.Sendblue,
                "slack" => ConnectConnectorType.Slack,
                "snowflake" => ConnectConnectorType.Snowflake,
                "snowflake-wif" => ConnectConnectorType.SnowflakeWif,
                _ => null,
            };
        }
    }
}
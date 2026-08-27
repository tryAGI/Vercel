
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which subject the connector issues tokens for. Defaults to \"app\" (connector-level keys). \"user\" connectors store no connector-level values; each user supplies their own key during authorization.
    /// </summary>
    public enum ConnectConnectorCreateDataTypeApiKeySubjectType
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreateDataTypeApiKeySubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateDataTypeApiKeySubjectType value)
        {
            return value switch
            {
                ConnectConnectorCreateDataTypeApiKeySubjectType.App => "app",
                ConnectConnectorCreateDataTypeApiKeySubjectType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateDataTypeApiKeySubjectType? ToEnum(string value)
        {
            return value switch
            {
                "app" => ConnectConnectorCreateDataTypeApiKeySubjectType.App,
                "user" => ConnectConnectorCreateDataTypeApiKeySubjectType.User,
                _ => null,
            };
        }
    }
}
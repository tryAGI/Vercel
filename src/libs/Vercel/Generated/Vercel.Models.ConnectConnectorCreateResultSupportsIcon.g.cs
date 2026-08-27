
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the connector icon can propagate to the provider.
    /// </summary>
    public enum ConnectConnectorCreateResultSupportsIcon
    {
        /// <summary>
        ///
        /// </summary>
        False,
        /// <summary>
        ///
        /// </summary>
        Maybe,
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreateResultSupportsIconExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateResultSupportsIcon value)
        {
            return value switch
            {
                ConnectConnectorCreateResultSupportsIcon.False => "false",
                ConnectConnectorCreateResultSupportsIcon.Maybe => "maybe",
                ConnectConnectorCreateResultSupportsIcon.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateResultSupportsIcon? ToEnum(string value)
        {
            return value switch
            {
                "false" => ConnectConnectorCreateResultSupportsIcon.False,
                "maybe" => ConnectConnectorCreateResultSupportsIcon.Maybe,
                "true" => ConnectConnectorCreateResultSupportsIcon.True,
                _ => null,
            };
        }
    }
}
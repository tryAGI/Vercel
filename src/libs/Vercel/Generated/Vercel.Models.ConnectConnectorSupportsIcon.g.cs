
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the connector icon can propagate to the provider.
    /// </summary>
    public enum ConnectConnectorSupportsIcon
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
    public static class ConnectConnectorSupportsIconExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorSupportsIcon value)
        {
            return value switch
            {
                ConnectConnectorSupportsIcon.False => "false",
                ConnectConnectorSupportsIcon.Maybe => "maybe",
                ConnectConnectorSupportsIcon.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorSupportsIcon? ToEnum(string value)
        {
            return value switch
            {
                "false" => ConnectConnectorSupportsIcon.False,
                "maybe" => ConnectConnectorSupportsIcon.Maybe,
                "true" => ConnectConnectorSupportsIcon.True,
                _ => null,
            };
        }
    }
}
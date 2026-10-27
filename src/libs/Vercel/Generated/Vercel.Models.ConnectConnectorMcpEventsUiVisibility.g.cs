
#nullable enable

namespace Vercel
{
    /// <summary>
    /// MCP Events dashboard visibility. Defaults to auto: show after the first successful delivery.
    /// </summary>
    public enum ConnectConnectorMcpEventsUiVisibility
    {
        /// <summary>
        /// show after the first successful delivery.
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Hide,
        /// <summary>
        /// show after the first successful delivery.
        /// </summary>
        Show,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorMcpEventsUiVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorMcpEventsUiVisibility value)
        {
            return value switch
            {
                ConnectConnectorMcpEventsUiVisibility.Auto => "auto",
                ConnectConnectorMcpEventsUiVisibility.Hide => "hide",
                ConnectConnectorMcpEventsUiVisibility.Show => "show",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorMcpEventsUiVisibility? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ConnectConnectorMcpEventsUiVisibility.Auto,
                "hide" => ConnectConnectorMcpEventsUiVisibility.Hide,
                "show" => ConnectConnectorMcpEventsUiVisibility.Show,
                _ => null,
            };
        }
    }
}
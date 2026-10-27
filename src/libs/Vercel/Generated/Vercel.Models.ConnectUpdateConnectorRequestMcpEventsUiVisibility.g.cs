
#nullable enable

namespace Vercel
{
    /// <summary>
    /// MCP Events dashboard visibility. Auto (the default) shows the UI after the first successful delivery. Show and hide persist regardless of future deliveries. This does not enable or disable event delivery.
    /// </summary>
    public enum ConnectUpdateConnectorRequestMcpEventsUiVisibility
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Hide,
        /// <summary>
        ///
        /// </summary>
        Show,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectUpdateConnectorRequestMcpEventsUiVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectUpdateConnectorRequestMcpEventsUiVisibility value)
        {
            return value switch
            {
                ConnectUpdateConnectorRequestMcpEventsUiVisibility.Auto => "auto",
                ConnectUpdateConnectorRequestMcpEventsUiVisibility.Hide => "hide",
                ConnectUpdateConnectorRequestMcpEventsUiVisibility.Show => "show",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectUpdateConnectorRequestMcpEventsUiVisibility? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ConnectUpdateConnectorRequestMcpEventsUiVisibility.Auto,
                "hide" => ConnectUpdateConnectorRequestMcpEventsUiVisibility.Hide,
                "show" => ConnectUpdateConnectorRequestMcpEventsUiVisibility.Show,
                _ => null,
            };
        }
    }
}
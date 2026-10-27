
#nullable enable

namespace Vercel
{
    /// <summary>
    /// MCP Events dashboard visibility. Defaults to auto: show after the first successful delivery.
    /// </summary>
    public enum ConnectConnectorCreateResultMcpEventsUiVisibility
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
    public static class ConnectConnectorCreateResultMcpEventsUiVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateResultMcpEventsUiVisibility value)
        {
            return value switch
            {
                ConnectConnectorCreateResultMcpEventsUiVisibility.Auto => "auto",
                ConnectConnectorCreateResultMcpEventsUiVisibility.Hide => "hide",
                ConnectConnectorCreateResultMcpEventsUiVisibility.Show => "show",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateResultMcpEventsUiVisibility? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ConnectConnectorCreateResultMcpEventsUiVisibility.Auto,
                "hide" => ConnectConnectorCreateResultMcpEventsUiVisibility.Hide,
                "show" => ConnectConnectorCreateResultMcpEventsUiVisibility.Show,
                _ => null,
            };
        }
    }
}
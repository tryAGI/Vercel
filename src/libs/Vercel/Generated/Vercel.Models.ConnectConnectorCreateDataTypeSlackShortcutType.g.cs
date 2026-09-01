
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where Slack exposes the shortcut.
    /// </summary>
    public enum ConnectConnectorCreateDataTypeSlackShortcutType
    {
        /// <summary>
        ///
        /// </summary>
        Global,
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreateDataTypeSlackShortcutTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateDataTypeSlackShortcutType value)
        {
            return value switch
            {
                ConnectConnectorCreateDataTypeSlackShortcutType.Global => "global",
                ConnectConnectorCreateDataTypeSlackShortcutType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateDataTypeSlackShortcutType? ToEnum(string value)
        {
            return value switch
            {
                "global" => ConnectConnectorCreateDataTypeSlackShortcutType.Global,
                "message" => ConnectConnectorCreateDataTypeSlackShortcutType.Message,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Where Slack exposes the shortcut.
    /// </summary>
    public enum ConnectConnectorUpdateDataTypeSlackShortcutType
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
    public static class ConnectConnectorUpdateDataTypeSlackShortcutTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorUpdateDataTypeSlackShortcutType value)
        {
            return value switch
            {
                ConnectConnectorUpdateDataTypeSlackShortcutType.Global => "global",
                ConnectConnectorUpdateDataTypeSlackShortcutType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorUpdateDataTypeSlackShortcutType? ToEnum(string value)
        {
            return value switch
            {
                "global" => ConnectConnectorUpdateDataTypeSlackShortcutType.Global,
                "message" => ConnectConnectorUpdateDataTypeSlackShortcutType.Message,
                _ => null,
            };
        }
    }
}
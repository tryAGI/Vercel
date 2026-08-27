
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the connector row was originally created. New create paths stamp this explicitly; older rows may omit it.
    /// </summary>
    public enum ConnectConnectorCreateResultCreationMode
    {
        /// <summary>
        ///
        /// </summary>
        Managed,
        /// <summary>
        ///
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreateResultCreationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateResultCreationMode value)
        {
            return value switch
            {
                ConnectConnectorCreateResultCreationMode.Managed => "managed",
                ConnectConnectorCreateResultCreationMode.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateResultCreationMode? ToEnum(string value)
        {
            return value switch
            {
                "managed" => ConnectConnectorCreateResultCreationMode.Managed,
                "manual" => ConnectConnectorCreateResultCreationMode.Manual,
                _ => null,
            };
        }
    }
}
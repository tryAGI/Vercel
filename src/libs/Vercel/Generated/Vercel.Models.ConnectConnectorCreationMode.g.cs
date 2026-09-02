
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the connector row was originally created. New create paths stamp this explicitly; older rows may omit it.
    /// </summary>
    public enum ConnectConnectorCreationMode
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
    public static class ConnectConnectorCreationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreationMode value)
        {
            return value switch
            {
                ConnectConnectorCreationMode.Managed => "managed",
                ConnectConnectorCreationMode.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreationMode? ToEnum(string value)
        {
            return value switch
            {
                "managed" => ConnectConnectorCreationMode.Managed,
                "manual" => ConnectConnectorCreationMode.Manual,
                _ => null,
            };
        }
    }
}
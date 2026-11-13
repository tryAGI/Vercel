
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ConnectConnectorUpdatedByVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorUpdatedByVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorUpdatedByVariant1Type value)
        {
            return value switch
            {
                ConnectConnectorUpdatedByVariant1Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorUpdatedByVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => ConnectConnectorUpdatedByVariant1Type.App,
                _ => null,
            };
        }
    }
}
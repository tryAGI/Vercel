
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ConnectConnectorCreatedByVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreatedByVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreatedByVariant1Type value)
        {
            return value switch
            {
                ConnectConnectorCreatedByVariant1Type.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreatedByVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "app" => ConnectConnectorCreatedByVariant1Type.App,
                _ => null,
            };
        }
    }
}
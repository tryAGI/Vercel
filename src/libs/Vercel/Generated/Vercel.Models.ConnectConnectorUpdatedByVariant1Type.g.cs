
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal kind.
    /// </summary>
    public enum ConnectConnectorUpdatedByVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        User,
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
                ConnectConnectorUpdatedByVariant1Type.User => "user",
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
                "user" => ConnectConnectorUpdatedByVariant1Type.User,
                _ => null,
            };
        }
    }
}
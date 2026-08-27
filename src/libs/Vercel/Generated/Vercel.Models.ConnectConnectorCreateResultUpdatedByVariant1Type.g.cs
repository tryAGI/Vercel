
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal kind.
    /// </summary>
    public enum ConnectConnectorCreateResultUpdatedByVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreateResultUpdatedByVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateResultUpdatedByVariant1Type value)
        {
            return value switch
            {
                ConnectConnectorCreateResultUpdatedByVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateResultUpdatedByVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => ConnectConnectorCreateResultUpdatedByVariant1Type.User,
                _ => null,
            };
        }
    }
}
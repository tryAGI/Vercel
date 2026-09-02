
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal kind.
    /// </summary>
    public enum ConnectConnectorCreatedByVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        User,
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
                ConnectConnectorCreatedByVariant1Type.User => "user",
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
                "user" => ConnectConnectorCreatedByVariant1Type.User,
                _ => null,
            };
        }
    }
}
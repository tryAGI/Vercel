
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal kind.
    /// </summary>
    public enum ConnectConnectorCreateResultUpdatedByVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreateResultUpdatedByVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateResultUpdatedByVariant2Type value)
        {
            return value switch
            {
                ConnectConnectorCreateResultUpdatedByVariant2Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateResultUpdatedByVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => ConnectConnectorCreateResultUpdatedByVariant2Type.User,
                _ => null,
            };
        }
    }
}
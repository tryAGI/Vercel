
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal kind.
    /// </summary>
    public enum ConnectConnectorCreateResultUpdatedByVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreateResultUpdatedByVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateResultUpdatedByVariant3Type value)
        {
            return value switch
            {
                ConnectConnectorCreateResultUpdatedByVariant3Type.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateResultUpdatedByVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "project" => ConnectConnectorCreateResultUpdatedByVariant3Type.Project,
                _ => null,
            };
        }
    }
}
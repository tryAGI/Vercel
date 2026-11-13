
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal kind.
    /// </summary>
    public enum ConnectConnectorCreateResultCreatedByVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreateResultCreatedByVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateResultCreatedByVariant3Type value)
        {
            return value switch
            {
                ConnectConnectorCreateResultCreatedByVariant3Type.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateResultCreatedByVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "project" => ConnectConnectorCreateResultCreatedByVariant3Type.Project,
                _ => null,
            };
        }
    }
}

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
        Project,
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
                ConnectConnectorCreateResultUpdatedByVariant2Type.Project => "project",
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
                "project" => ConnectConnectorCreateResultUpdatedByVariant2Type.Project,
                _ => null,
            };
        }
    }
}
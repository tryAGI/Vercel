
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal kind.
    /// </summary>
    public enum ConnectConnectorUpdatedByVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorUpdatedByVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorUpdatedByVariant2Type value)
        {
            return value switch
            {
                ConnectConnectorUpdatedByVariant2Type.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorUpdatedByVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "project" => ConnectConnectorUpdatedByVariant2Type.Project,
                _ => null,
            };
        }
    }
}
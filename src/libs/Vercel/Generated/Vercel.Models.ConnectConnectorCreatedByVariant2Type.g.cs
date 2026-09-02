
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal kind.
    /// </summary>
    public enum ConnectConnectorCreatedByVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreatedByVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreatedByVariant2Type value)
        {
            return value switch
            {
                ConnectConnectorCreatedByVariant2Type.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreatedByVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "project" => ConnectConnectorCreatedByVariant2Type.Project,
                _ => null,
            };
        }
    }
}
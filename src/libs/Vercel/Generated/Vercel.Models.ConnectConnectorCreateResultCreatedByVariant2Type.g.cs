
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal kind.
    /// </summary>
    public enum ConnectConnectorCreateResultCreatedByVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectConnectorCreateResultCreatedByVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectConnectorCreateResultCreatedByVariant2Type value)
        {
            return value switch
            {
                ConnectConnectorCreateResultCreatedByVariant2Type.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectConnectorCreateResultCreatedByVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "project" => ConnectConnectorCreateResultCreatedByVariant2Type.Project,
                _ => null,
            };
        }
    }
}
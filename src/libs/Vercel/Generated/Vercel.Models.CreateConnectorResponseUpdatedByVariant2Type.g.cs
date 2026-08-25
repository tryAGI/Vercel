
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal kind.
    /// </summary>
    public enum CreateConnectorResponseUpdatedByVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorResponseUpdatedByVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorResponseUpdatedByVariant2Type value)
        {
            return value switch
            {
                CreateConnectorResponseUpdatedByVariant2Type.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorResponseUpdatedByVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "project" => CreateConnectorResponseUpdatedByVariant2Type.Project,
                _ => null,
            };
        }
    }
}
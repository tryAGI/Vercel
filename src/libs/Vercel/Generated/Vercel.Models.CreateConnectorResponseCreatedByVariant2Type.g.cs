
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal kind.
    /// </summary>
    public enum CreateConnectorResponseCreatedByVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorResponseCreatedByVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorResponseCreatedByVariant2Type value)
        {
            return value switch
            {
                CreateConnectorResponseCreatedByVariant2Type.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorResponseCreatedByVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "project" => CreateConnectorResponseCreatedByVariant2Type.Project,
                _ => null,
            };
        }
    }
}
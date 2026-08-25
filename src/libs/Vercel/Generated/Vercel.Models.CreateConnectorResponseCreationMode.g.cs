
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How the connector row was originally created. New create paths stamp this explicitly; older rows may omit it.
    /// </summary>
    public enum CreateConnectorResponseCreationMode
    {
        /// <summary>
        /// 
        /// </summary>
        Managed,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorResponseCreationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorResponseCreationMode value)
        {
            return value switch
            {
                CreateConnectorResponseCreationMode.Managed => "managed",
                CreateConnectorResponseCreationMode.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorResponseCreationMode? ToEnum(string value)
        {
            return value switch
            {
                "managed" => CreateConnectorResponseCreationMode.Managed,
                "manual" => CreateConnectorResponseCreationMode.Manual,
                _ => null,
            };
        }
    }
}
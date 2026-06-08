
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorResponseSupportsIcon
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        Maybe,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorResponseSupportsIconExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorResponseSupportsIcon value)
        {
            return value switch
            {
                CreateConnectorResponseSupportsIcon.False => "false",
                CreateConnectorResponseSupportsIcon.Maybe => "maybe",
                CreateConnectorResponseSupportsIcon.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorResponseSupportsIcon? ToEnum(string value)
        {
            return value switch
            {
                "false" => CreateConnectorResponseSupportsIcon.False,
                "maybe" => CreateConnectorResponseSupportsIcon.Maybe,
                "true" => CreateConnectorResponseSupportsIcon.True,
                _ => null,
            };
        }
    }
}
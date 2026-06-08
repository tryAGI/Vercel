
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorResponseCreatedByVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorResponseCreatedByVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorResponseCreatedByVariant1Type value)
        {
            return value switch
            {
                CreateConnectorResponseCreatedByVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorResponseCreatedByVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => CreateConnectorResponseCreatedByVariant1Type.User,
                _ => null,
            };
        }
    }
}
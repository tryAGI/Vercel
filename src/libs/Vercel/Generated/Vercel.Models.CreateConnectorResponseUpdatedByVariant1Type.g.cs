
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConnectorResponseUpdatedByVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConnectorResponseUpdatedByVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConnectorResponseUpdatedByVariant1Type value)
        {
            return value switch
            {
                CreateConnectorResponseUpdatedByVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConnectorResponseUpdatedByVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => CreateConnectorResponseUpdatedByVariant1Type.User,
                _ => null,
            };
        }
    }
}
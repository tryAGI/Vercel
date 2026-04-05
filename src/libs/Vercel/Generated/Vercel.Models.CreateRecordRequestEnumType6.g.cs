
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be of type `MX`.
    /// </summary>
    public enum CreateRecordRequestEnumType6
    {
        /// <summary>
        /// 
        /// </summary>
        Mx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecordRequestEnumType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecordRequestEnumType6 value)
        {
            return value switch
            {
                CreateRecordRequestEnumType6.Mx => "MX",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecordRequestEnumType6? ToEnum(string value)
        {
            return value switch
            {
                "MX" => CreateRecordRequestEnumType6.Mx,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be of type `CAA`.
    /// </summary>
    public enum CreateRecordRequestEnumType4
    {
        /// <summary>
        /// 
        /// </summary>
        Caa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecordRequestEnumType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecordRequestEnumType4 value)
        {
            return value switch
            {
                CreateRecordRequestEnumType4.Caa => "CAA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecordRequestEnumType4? ToEnum(string value)
        {
            return value switch
            {
                "CAA" => CreateRecordRequestEnumType4.Caa,
                _ => null,
            };
        }
    }
}
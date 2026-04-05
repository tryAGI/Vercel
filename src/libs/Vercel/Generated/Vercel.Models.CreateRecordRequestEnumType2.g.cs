
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be of type `AAAA`.
    /// </summary>
    public enum CreateRecordRequestEnumType2
    {
        /// <summary>
        /// 
        /// </summary>
        Aaaa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecordRequestEnumType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecordRequestEnumType2 value)
        {
            return value switch
            {
                CreateRecordRequestEnumType2.Aaaa => "AAAA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecordRequestEnumType2? ToEnum(string value)
        {
            return value switch
            {
                "AAAA" => CreateRecordRequestEnumType2.Aaaa,
                _ => null,
            };
        }
    }
}
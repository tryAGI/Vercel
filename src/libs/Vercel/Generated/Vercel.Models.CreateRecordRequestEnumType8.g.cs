
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be of type `TXT`.
    /// </summary>
    public enum CreateRecordRequestEnumType8
    {
        /// <summary>
        /// 
        /// </summary>
        Txt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecordRequestEnumType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecordRequestEnumType8 value)
        {
            return value switch
            {
                CreateRecordRequestEnumType8.Txt => "TXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecordRequestEnumType8? ToEnum(string value)
        {
            return value switch
            {
                "TXT" => CreateRecordRequestEnumType8.Txt,
                _ => null,
            };
        }
    }
}
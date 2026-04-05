
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be of type `CNAME`.
    /// </summary>
    public enum CreateRecordRequestEnumType5
    {
        /// <summary>
        /// 
        /// </summary>
        Cname,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecordRequestEnumType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecordRequestEnumType5 value)
        {
            return value switch
            {
                CreateRecordRequestEnumType5.Cname => "CNAME",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecordRequestEnumType5? ToEnum(string value)
        {
            return value switch
            {
                "CNAME" => CreateRecordRequestEnumType5.Cname,
                _ => null,
            };
        }
    }
}
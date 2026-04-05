
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be of type `NS`.
    /// </summary>
    public enum CreateRecordRequestEnumType9
    {
        /// <summary>
        /// 
        /// </summary>
        Ns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecordRequestEnumType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecordRequestEnumType9 value)
        {
            return value switch
            {
                CreateRecordRequestEnumType9.Ns => "NS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecordRequestEnumType9? ToEnum(string value)
        {
            return value switch
            {
                "NS" => CreateRecordRequestEnumType9.Ns,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be of type `A`.
    /// </summary>
    public enum CreateRecordRequestEnumType
    {
        /// <summary>
        /// 
        /// </summary>
        A,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecordRequestEnumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecordRequestEnumType value)
        {
            return value switch
            {
                CreateRecordRequestEnumType.A => "A",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecordRequestEnumType? ToEnum(string value)
        {
            return value switch
            {
                "A" => CreateRecordRequestEnumType.A,
                _ => null,
            };
        }
    }
}
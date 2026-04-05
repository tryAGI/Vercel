
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be of type `ALIAS`.
    /// </summary>
    public enum CreateRecordRequestEnumType3
    {
        /// <summary>
        /// 
        /// </summary>
        Alias,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecordRequestEnumType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecordRequestEnumType3 value)
        {
            return value switch
            {
                CreateRecordRequestEnumType3.Alias => "ALIAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecordRequestEnumType3? ToEnum(string value)
        {
            return value switch
            {
                "ALIAS" => CreateRecordRequestEnumType3.Alias,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be of type `HTTPS`.
    /// </summary>
    public enum CreateRecordRequestEnumType10
    {
        /// <summary>
        /// 
        /// </summary>
        Https,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecordRequestEnumType10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecordRequestEnumType10 value)
        {
            return value switch
            {
                CreateRecordRequestEnumType10.Https => "HTTPS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecordRequestEnumType10? ToEnum(string value)
        {
            return value switch
            {
                "HTTPS" => CreateRecordRequestEnumType10.Https,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be of type `SRV`.
    /// </summary>
    public enum CreateRecordRequestEnumType7
    {
        /// <summary>
        /// 
        /// </summary>
        Srv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRecordRequestEnumType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecordRequestEnumType7 value)
        {
            return value switch
            {
                CreateRecordRequestEnumType7.Srv => "SRV",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecordRequestEnumType7? ToEnum(string value)
        {
            return value switch
            {
                "SRV" => CreateRecordRequestEnumType7.Srv,
                _ => null,
            };
        }
    }
}
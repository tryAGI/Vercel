
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRecordResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Record,
        /// <summary>
        /// 
        /// </summary>
        RecordSys,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRecordResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRecordResponseType value)
        {
            return value switch
            {
                UpdateRecordResponseType.Record => "record",
                UpdateRecordResponseType.RecordSys => "record-sys",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRecordResponseType? ToEnum(string value)
        {
            return value switch
            {
                "record" => UpdateRecordResponseType.Record,
                "record-sys" => UpdateRecordResponseType.RecordSys,
                _ => null,
            };
        }
    }
}
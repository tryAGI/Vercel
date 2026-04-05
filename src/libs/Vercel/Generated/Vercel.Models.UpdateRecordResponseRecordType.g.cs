
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRecordResponseRecordType
    {
        /// <summary>
        /// 
        /// </summary>
        A,
        /// <summary>
        /// 
        /// </summary>
        Aaaa,
        /// <summary>
        /// 
        /// </summary>
        Alias,
        /// <summary>
        /// 
        /// </summary>
        Caa,
        /// <summary>
        /// 
        /// </summary>
        Cname,
        /// <summary>
        /// 
        /// </summary>
        Https,
        /// <summary>
        /// 
        /// </summary>
        Mx,
        /// <summary>
        /// 
        /// </summary>
        Ns,
        /// <summary>
        /// 
        /// </summary>
        Srv,
        /// <summary>
        /// 
        /// </summary>
        Txt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRecordResponseRecordTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRecordResponseRecordType value)
        {
            return value switch
            {
                UpdateRecordResponseRecordType.A => "A",
                UpdateRecordResponseRecordType.Aaaa => "AAAA",
                UpdateRecordResponseRecordType.Alias => "ALIAS",
                UpdateRecordResponseRecordType.Caa => "CAA",
                UpdateRecordResponseRecordType.Cname => "CNAME",
                UpdateRecordResponseRecordType.Https => "HTTPS",
                UpdateRecordResponseRecordType.Mx => "MX",
                UpdateRecordResponseRecordType.Ns => "NS",
                UpdateRecordResponseRecordType.Srv => "SRV",
                UpdateRecordResponseRecordType.Txt => "TXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRecordResponseRecordType? ToEnum(string value)
        {
            return value switch
            {
                "A" => UpdateRecordResponseRecordType.A,
                "AAAA" => UpdateRecordResponseRecordType.Aaaa,
                "ALIAS" => UpdateRecordResponseRecordType.Alias,
                "CAA" => UpdateRecordResponseRecordType.Caa,
                "CNAME" => UpdateRecordResponseRecordType.Cname,
                "HTTPS" => UpdateRecordResponseRecordType.Https,
                "MX" => UpdateRecordResponseRecordType.Mx,
                "NS" => UpdateRecordResponseRecordType.Ns,
                "SRV" => UpdateRecordResponseRecordType.Srv,
                "TXT" => UpdateRecordResponseRecordType.Txt,
                _ => null,
            };
        }
    }
}
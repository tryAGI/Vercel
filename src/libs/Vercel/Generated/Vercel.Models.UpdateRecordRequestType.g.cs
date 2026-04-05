
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of the DNS record<br/>
    /// Example: A
    /// </summary>
    public enum UpdateRecordRequestType
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
    public static class UpdateRecordRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRecordRequestType value)
        {
            return value switch
            {
                UpdateRecordRequestType.A => "A",
                UpdateRecordRequestType.Aaaa => "AAAA",
                UpdateRecordRequestType.Alias => "ALIAS",
                UpdateRecordRequestType.Caa => "CAA",
                UpdateRecordRequestType.Cname => "CNAME",
                UpdateRecordRequestType.Https => "HTTPS",
                UpdateRecordRequestType.Mx => "MX",
                UpdateRecordRequestType.Ns => "NS",
                UpdateRecordRequestType.Srv => "SRV",
                UpdateRecordRequestType.Txt => "TXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRecordRequestType? ToEnum(string value)
        {
            return value switch
            {
                "A" => UpdateRecordRequestType.A,
                "AAAA" => UpdateRecordRequestType.Aaaa,
                "ALIAS" => UpdateRecordRequestType.Alias,
                "CAA" => UpdateRecordRequestType.Caa,
                "CNAME" => UpdateRecordRequestType.Cname,
                "HTTPS" => UpdateRecordRequestType.Https,
                "MX" => UpdateRecordRequestType.Mx,
                "NS" => UpdateRecordRequestType.Ns,
                "SRV" => UpdateRecordRequestType.Srv,
                "TXT" => UpdateRecordRequestType.Txt,
                _ => null,
            };
        }
    }
}
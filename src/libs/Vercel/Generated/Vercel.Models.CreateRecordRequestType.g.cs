
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of record, it could be one of the valid DNS records.
    /// </summary>
    public enum CreateRecordRequestType
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
    public static class CreateRecordRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRecordRequestType value)
        {
            return value switch
            {
                CreateRecordRequestType.A => "A",
                CreateRecordRequestType.Aaaa => "AAAA",
                CreateRecordRequestType.Alias => "ALIAS",
                CreateRecordRequestType.Caa => "CAA",
                CreateRecordRequestType.Cname => "CNAME",
                CreateRecordRequestType.Https => "HTTPS",
                CreateRecordRequestType.Mx => "MX",
                CreateRecordRequestType.Ns => "NS",
                CreateRecordRequestType.Srv => "SRV",
                CreateRecordRequestType.Txt => "TXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRecordRequestType? ToEnum(string value)
        {
            return value switch
            {
                "A" => CreateRecordRequestType.A,
                "AAAA" => CreateRecordRequestType.Aaaa,
                "ALIAS" => CreateRecordRequestType.Alias,
                "CAA" => CreateRecordRequestType.Caa,
                "CNAME" => CreateRecordRequestType.Cname,
                "HTTPS" => CreateRecordRequestType.Https,
                "MX" => CreateRecordRequestType.Mx,
                "NS" => CreateRecordRequestType.Ns,
                "SRV" => CreateRecordRequestType.Srv,
                "TXT" => CreateRecordRequestType.Txt,
                _ => null,
            };
        }
    }
}
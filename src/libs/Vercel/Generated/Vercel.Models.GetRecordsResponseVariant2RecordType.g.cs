
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRecordsResponseVariant2RecordType
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
    public static class GetRecordsResponseVariant2RecordTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRecordsResponseVariant2RecordType value)
        {
            return value switch
            {
                GetRecordsResponseVariant2RecordType.A => "A",
                GetRecordsResponseVariant2RecordType.Aaaa => "AAAA",
                GetRecordsResponseVariant2RecordType.Alias => "ALIAS",
                GetRecordsResponseVariant2RecordType.Caa => "CAA",
                GetRecordsResponseVariant2RecordType.Cname => "CNAME",
                GetRecordsResponseVariant2RecordType.Https => "HTTPS",
                GetRecordsResponseVariant2RecordType.Mx => "MX",
                GetRecordsResponseVariant2RecordType.Ns => "NS",
                GetRecordsResponseVariant2RecordType.Srv => "SRV",
                GetRecordsResponseVariant2RecordType.Txt => "TXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRecordsResponseVariant2RecordType? ToEnum(string value)
        {
            return value switch
            {
                "A" => GetRecordsResponseVariant2RecordType.A,
                "AAAA" => GetRecordsResponseVariant2RecordType.Aaaa,
                "ALIAS" => GetRecordsResponseVariant2RecordType.Alias,
                "CAA" => GetRecordsResponseVariant2RecordType.Caa,
                "CNAME" => GetRecordsResponseVariant2RecordType.Cname,
                "HTTPS" => GetRecordsResponseVariant2RecordType.Https,
                "MX" => GetRecordsResponseVariant2RecordType.Mx,
                "NS" => GetRecordsResponseVariant2RecordType.Ns,
                "SRV" => GetRecordsResponseVariant2RecordType.Srv,
                "TXT" => GetRecordsResponseVariant2RecordType.Txt,
                _ => null,
            };
        }
    }
}
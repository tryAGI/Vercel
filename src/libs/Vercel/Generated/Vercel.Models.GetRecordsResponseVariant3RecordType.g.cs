
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRecordsResponseVariant3RecordType
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
    public static class GetRecordsResponseVariant3RecordTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRecordsResponseVariant3RecordType value)
        {
            return value switch
            {
                GetRecordsResponseVariant3RecordType.A => "A",
                GetRecordsResponseVariant3RecordType.Aaaa => "AAAA",
                GetRecordsResponseVariant3RecordType.Alias => "ALIAS",
                GetRecordsResponseVariant3RecordType.Caa => "CAA",
                GetRecordsResponseVariant3RecordType.Cname => "CNAME",
                GetRecordsResponseVariant3RecordType.Https => "HTTPS",
                GetRecordsResponseVariant3RecordType.Mx => "MX",
                GetRecordsResponseVariant3RecordType.Ns => "NS",
                GetRecordsResponseVariant3RecordType.Srv => "SRV",
                GetRecordsResponseVariant3RecordType.Txt => "TXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRecordsResponseVariant3RecordType? ToEnum(string value)
        {
            return value switch
            {
                "A" => GetRecordsResponseVariant3RecordType.A,
                "AAAA" => GetRecordsResponseVariant3RecordType.Aaaa,
                "ALIAS" => GetRecordsResponseVariant3RecordType.Alias,
                "CAA" => GetRecordsResponseVariant3RecordType.Caa,
                "CNAME" => GetRecordsResponseVariant3RecordType.Cname,
                "HTTPS" => GetRecordsResponseVariant3RecordType.Https,
                "MX" => GetRecordsResponseVariant3RecordType.Mx,
                "NS" => GetRecordsResponseVariant3RecordType.Ns,
                "SRV" => GetRecordsResponseVariant3RecordType.Srv,
                "TXT" => GetRecordsResponseVariant3RecordType.Txt,
                _ => null,
            };
        }
    }
}
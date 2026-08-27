
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDomainsRecordsByRecordIdResponseRecordType
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
    public static class GetDomainsRecordsByRecordIdResponseRecordTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDomainsRecordsByRecordIdResponseRecordType value)
        {
            return value switch
            {
                GetDomainsRecordsByRecordIdResponseRecordType.A => "A",
                GetDomainsRecordsByRecordIdResponseRecordType.Aaaa => "AAAA",
                GetDomainsRecordsByRecordIdResponseRecordType.Alias => "ALIAS",
                GetDomainsRecordsByRecordIdResponseRecordType.Caa => "CAA",
                GetDomainsRecordsByRecordIdResponseRecordType.Cname => "CNAME",
                GetDomainsRecordsByRecordIdResponseRecordType.Https => "HTTPS",
                GetDomainsRecordsByRecordIdResponseRecordType.Mx => "MX",
                GetDomainsRecordsByRecordIdResponseRecordType.Ns => "NS",
                GetDomainsRecordsByRecordIdResponseRecordType.Srv => "SRV",
                GetDomainsRecordsByRecordIdResponseRecordType.Txt => "TXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDomainsRecordsByRecordIdResponseRecordType? ToEnum(string value)
        {
            return value switch
            {
                "A" => GetDomainsRecordsByRecordIdResponseRecordType.A,
                "AAAA" => GetDomainsRecordsByRecordIdResponseRecordType.Aaaa,
                "ALIAS" => GetDomainsRecordsByRecordIdResponseRecordType.Alias,
                "CAA" => GetDomainsRecordsByRecordIdResponseRecordType.Caa,
                "CNAME" => GetDomainsRecordsByRecordIdResponseRecordType.Cname,
                "HTTPS" => GetDomainsRecordsByRecordIdResponseRecordType.Https,
                "MX" => GetDomainsRecordsByRecordIdResponseRecordType.Mx,
                "NS" => GetDomainsRecordsByRecordIdResponseRecordType.Ns,
                "SRV" => GetDomainsRecordsByRecordIdResponseRecordType.Srv,
                "TXT" => GetDomainsRecordsByRecordIdResponseRecordType.Txt,
                _ => null,
            };
        }
    }
}
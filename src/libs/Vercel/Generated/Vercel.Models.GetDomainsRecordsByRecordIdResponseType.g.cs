
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDomainsRecordsByRecordIdResponseType
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
    public static class GetDomainsRecordsByRecordIdResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDomainsRecordsByRecordIdResponseType value)
        {
            return value switch
            {
                GetDomainsRecordsByRecordIdResponseType.A => "A",
                GetDomainsRecordsByRecordIdResponseType.Aaaa => "AAAA",
                GetDomainsRecordsByRecordIdResponseType.Alias => "ALIAS",
                GetDomainsRecordsByRecordIdResponseType.Caa => "CAA",
                GetDomainsRecordsByRecordIdResponseType.Cname => "CNAME",
                GetDomainsRecordsByRecordIdResponseType.Https => "HTTPS",
                GetDomainsRecordsByRecordIdResponseType.Mx => "MX",
                GetDomainsRecordsByRecordIdResponseType.Ns => "NS",
                GetDomainsRecordsByRecordIdResponseType.Srv => "SRV",
                GetDomainsRecordsByRecordIdResponseType.Txt => "TXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDomainsRecordsByRecordIdResponseType? ToEnum(string value)
        {
            return value switch
            {
                "A" => GetDomainsRecordsByRecordIdResponseType.A,
                "AAAA" => GetDomainsRecordsByRecordIdResponseType.Aaaa,
                "ALIAS" => GetDomainsRecordsByRecordIdResponseType.Alias,
                "CAA" => GetDomainsRecordsByRecordIdResponseType.Caa,
                "CNAME" => GetDomainsRecordsByRecordIdResponseType.Cname,
                "HTTPS" => GetDomainsRecordsByRecordIdResponseType.Https,
                "MX" => GetDomainsRecordsByRecordIdResponseType.Mx,
                "NS" => GetDomainsRecordsByRecordIdResponseType.Ns,
                "SRV" => GetDomainsRecordsByRecordIdResponseType.Srv,
                "TXT" => GetDomainsRecordsByRecordIdResponseType.Txt,
                _ => null,
            };
        }
    }
}
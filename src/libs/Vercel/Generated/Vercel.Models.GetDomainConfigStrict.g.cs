
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When true, the response will only include the nameservers assigned directly to the specified domain. When false and there are no nameservers assigned directly to the specified domain, the response will include the nameservers of the domain's parent zone.
    /// </summary>
    public enum GetDomainConfigStrict
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDomainConfigStrictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDomainConfigStrict value)
        {
            return value switch
            {
                GetDomainConfigStrict.False => "false",
                GetDomainConfigStrict.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDomainConfigStrict? ToEnum(string value)
        {
            return value switch
            {
                "false" => GetDomainConfigStrict.False,
                "true" => GetDomainConfigStrict.True,
                _ => null,
            };
        }
    }
}
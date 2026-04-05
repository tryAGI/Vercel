
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TooManyDomainsCode
    {
        /// <summary>
        /// 
        /// </summary>
        TooManyDomains,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TooManyDomainsCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TooManyDomainsCode value)
        {
            return value switch
            {
                TooManyDomainsCode.TooManyDomains => "too_many_domains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TooManyDomainsCode? ToEnum(string value)
        {
            return value switch
            {
                "too_many_domains" => TooManyDomainsCode.TooManyDomains,
                _ => null,
            };
        }
    }
}
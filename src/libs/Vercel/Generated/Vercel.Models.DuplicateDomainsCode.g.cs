
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DuplicateDomainsCode
    {
        /// <summary>
        /// 
        /// </summary>
        DuplicateDomains,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DuplicateDomainsCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DuplicateDomainsCode value)
        {
            return value switch
            {
                DuplicateDomainsCode.DuplicateDomains => "duplicate_domains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DuplicateDomainsCode? ToEnum(string value)
        {
            return value switch
            {
                "duplicate_domains" => DuplicateDomainsCode.DuplicateDomains,
                _ => null,
            };
        }
    }
}
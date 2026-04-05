
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainTooShortCode
    {
        /// <summary>
        /// 
        /// </summary>
        DomainTooShort,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainTooShortCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainTooShortCode value)
        {
            return value switch
            {
                DomainTooShortCode.DomainTooShort => "domain_too_short",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainTooShortCode? ToEnum(string value)
        {
            return value switch
            {
                "domain_too_short" => DomainTooShortCode.DomainTooShort,
                _ => null,
            };
        }
    }
}
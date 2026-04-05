
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainNotFoundCode
    {
        /// <summary>
        /// 
        /// </summary>
        DomainNotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainNotFoundCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainNotFoundCode value)
        {
            return value switch
            {
                DomainNotFoundCode.DomainNotFound => "domain_not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainNotFoundCode? ToEnum(string value)
        {
            return value switch
            {
                "domain_not_found" => DomainNotFoundCode.DomainNotFound,
                _ => null,
            };
        }
    }
}
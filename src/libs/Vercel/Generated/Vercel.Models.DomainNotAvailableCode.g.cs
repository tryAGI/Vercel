
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainNotAvailableCode
    {
        /// <summary>
        /// 
        /// </summary>
        DomainNotAvailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainNotAvailableCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainNotAvailableCode value)
        {
            return value switch
            {
                DomainNotAvailableCode.DomainNotAvailable => "domain_not_available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainNotAvailableCode? ToEnum(string value)
        {
            return value switch
            {
                "domain_not_available" => DomainNotAvailableCode.DomainNotAvailable,
                _ => null,
            };
        }
    }
}
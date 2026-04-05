
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainNotRenewableCode
    {
        /// <summary>
        /// 
        /// </summary>
        DomainNotRenewable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainNotRenewableCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainNotRenewableCode value)
        {
            return value switch
            {
                DomainNotRenewableCode.DomainNotRenewable => "domain_not_renewable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainNotRenewableCode? ToEnum(string value)
        {
            return value switch
            {
                "domain_not_renewable" => DomainNotRenewableCode.DomainNotRenewable,
                _ => null,
            };
        }
    }
}
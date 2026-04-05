
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainNotRegisteredCode
    {
        /// <summary>
        /// 
        /// </summary>
        DomainNotRegistered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainNotRegisteredCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainNotRegisteredCode value)
        {
            return value switch
            {
                DomainNotRegisteredCode.DomainNotRegistered => "domain_not_registered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainNotRegisteredCode? ToEnum(string value)
        {
            return value switch
            {
                "domain_not_registered" => DomainNotRegisteredCode.DomainNotRegistered,
                _ => null,
            };
        }
    }
}
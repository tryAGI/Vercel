
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainAlreadyRenewingCode
    {
        /// <summary>
        /// 
        /// </summary>
        DomainAlreadyRenewing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainAlreadyRenewingCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainAlreadyRenewingCode value)
        {
            return value switch
            {
                DomainAlreadyRenewingCode.DomainAlreadyRenewing => "domain_already_renewing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainAlreadyRenewingCode? ToEnum(string value)
        {
            return value switch
            {
                "domain_already_renewing" => DomainAlreadyRenewingCode.DomainAlreadyRenewing,
                _ => null,
            };
        }
    }
}
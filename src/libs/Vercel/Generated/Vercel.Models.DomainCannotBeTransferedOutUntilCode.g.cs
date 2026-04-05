
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainCannotBeTransferedOutUntilCode
    {
        /// <summary>
        /// 
        /// </summary>
        DomainCannotBeTransferedOutUntil,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainCannotBeTransferedOutUntilCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainCannotBeTransferedOutUntilCode value)
        {
            return value switch
            {
                DomainCannotBeTransferedOutUntilCode.DomainCannotBeTransferedOutUntil => "domain_cannot_be_transfered_out_until",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainCannotBeTransferedOutUntilCode? ToEnum(string value)
        {
            return value switch
            {
                "domain_cannot_be_transfered_out_until" => DomainCannotBeTransferedOutUntilCode.DomainCannotBeTransferedOutUntil,
                _ => null,
            };
        }
    }
}
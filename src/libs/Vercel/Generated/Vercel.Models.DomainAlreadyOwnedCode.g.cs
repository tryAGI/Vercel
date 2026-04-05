
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainAlreadyOwnedCode
    {
        /// <summary>
        /// 
        /// </summary>
        DomainAlreadyOwned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainAlreadyOwnedCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainAlreadyOwnedCode value)
        {
            return value switch
            {
                DomainAlreadyOwnedCode.DomainAlreadyOwned => "domain_already_owned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainAlreadyOwnedCode? ToEnum(string value)
        {
            return value switch
            {
                "domain_already_owned" => DomainAlreadyOwnedCode.DomainAlreadyOwned,
                _ => null,
            };
        }
    }
}
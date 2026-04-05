
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant3ErrorVariant4Code
    {
        /// <summary>
        /// 
        /// </summary>
        IncorrectAuthCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant3ErrorVariant4CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant3ErrorVariant4Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant3ErrorVariant4Code.IncorrectAuthCode => "incorrect-auth-code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant3ErrorVariant4Code? ToEnum(string value)
        {
            return value switch
            {
                "incorrect-auth-code" => GetOrderResponseDomainVariant3ErrorVariant4Code.IncorrectAuthCode,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant3ErrorVariant10Code
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidContact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant3ErrorVariant10CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant3ErrorVariant10Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant3ErrorVariant10Code.InvalidContact => "invalid-contact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant3ErrorVariant10Code? ToEnum(string value)
        {
            return value switch
            {
                "invalid-contact" => GetOrderResponseDomainVariant3ErrorVariant10Code.InvalidContact,
                _ => null,
            };
        }
    }
}
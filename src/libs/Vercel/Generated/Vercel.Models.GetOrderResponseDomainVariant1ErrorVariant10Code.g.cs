
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseDomainVariant1ErrorVariant10Code
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidContact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseDomainVariant1ErrorVariant10CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseDomainVariant1ErrorVariant10Code value)
        {
            return value switch
            {
                GetOrderResponseDomainVariant1ErrorVariant10Code.InvalidContact => "invalid-contact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseDomainVariant1ErrorVariant10Code? ToEnum(string value)
        {
            return value switch
            {
                "invalid-contact" => GetOrderResponseDomainVariant1ErrorVariant10Code.InvalidContact,
                _ => null,
            };
        }
    }
}
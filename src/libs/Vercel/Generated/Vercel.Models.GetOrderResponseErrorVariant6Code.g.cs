
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseErrorVariant6Code
    {
        /// <summary>
        /// 
        /// </summary>
        DomainMismatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseErrorVariant6CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseErrorVariant6Code value)
        {
            return value switch
            {
                GetOrderResponseErrorVariant6Code.DomainMismatch => "domain-mismatch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseErrorVariant6Code? ToEnum(string value)
        {
            return value switch
            {
                "domain-mismatch" => GetOrderResponseErrorVariant6Code.DomainMismatch,
                _ => null,
            };
        }
    }
}
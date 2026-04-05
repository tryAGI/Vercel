
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrderResponseErrorVariant5Code
    {
        /// <summary>
        /// 
        /// </summary>
        ClaimsRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseErrorVariant5CodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseErrorVariant5Code value)
        {
            return value switch
            {
                GetOrderResponseErrorVariant5Code.ClaimsRequired => "claims-required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseErrorVariant5Code? ToEnum(string value)
        {
            return value switch
            {
                "claims-required" => GetOrderResponseErrorVariant5Code.ClaimsRequired,
                _ => null,
            };
        }
    }
}
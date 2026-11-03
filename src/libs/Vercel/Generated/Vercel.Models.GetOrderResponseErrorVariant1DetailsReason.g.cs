
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrderResponseErrorVariant1DetailsReason
    {
        /// <summary>
        ///
        /// </summary>
        AuthenticationRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrderResponseErrorVariant1DetailsReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrderResponseErrorVariant1DetailsReason value)
        {
            return value switch
            {
                GetOrderResponseErrorVariant1DetailsReason.AuthenticationRequired => "authentication-required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrderResponseErrorVariant1DetailsReason? ToEnum(string value)
        {
            return value switch
            {
                "authentication-required" => GetOrderResponseErrorVariant1DetailsReason.AuthenticationRequired,
                _ => null,
            };
        }
    }
}
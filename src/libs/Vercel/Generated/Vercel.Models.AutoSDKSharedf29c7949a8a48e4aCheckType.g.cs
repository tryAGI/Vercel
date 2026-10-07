
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The metric this check evaluates.
    /// </summary>
    public enum AutoSDKSharedf29c7949a8a48e4aCheckType
    {
        /// <summary>
        ///
        /// </summary>
        ErrorRate5xx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedf29c7949a8a48e4aCheckTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf29c7949a8a48e4aCheckType value)
        {
            return value switch
            {
                AutoSDKSharedf29c7949a8a48e4aCheckType.ErrorRate5xx => "error-rate-5xx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf29c7949a8a48e4aCheckType? ToEnum(string value)
        {
            return value switch
            {
                "error-rate-5xx" => AutoSDKSharedf29c7949a8a48e4aCheckType.ErrorRate5xx,
                _ => null,
            };
        }
    }
}
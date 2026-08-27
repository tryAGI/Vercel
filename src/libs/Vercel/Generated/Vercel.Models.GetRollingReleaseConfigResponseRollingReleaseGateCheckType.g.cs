
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The metric this check evaluates.
    /// </summary>
    public enum GetRollingReleaseConfigResponseRollingReleaseGateCheckType
    {
        /// <summary>
        ///
        /// </summary>
        ErrorRate5xx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRollingReleaseConfigResponseRollingReleaseGateCheckTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRollingReleaseConfigResponseRollingReleaseGateCheckType value)
        {
            return value switch
            {
                GetRollingReleaseConfigResponseRollingReleaseGateCheckType.ErrorRate5xx => "error-rate-5xx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRollingReleaseConfigResponseRollingReleaseGateCheckType? ToEnum(string value)
        {
            return value switch
            {
                "error-rate-5xx" => GetRollingReleaseConfigResponseRollingReleaseGateCheckType.ErrorRate5xx,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// The metric this check evaluates.
    /// </summary>
    public enum GetProjectsResponseVariant1ItemRollingReleaseGateCheckType
    {
        /// <summary>
        /// 
        /// </summary>
        ErrorRate5xx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemRollingReleaseGateCheckTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemRollingReleaseGateCheckType value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemRollingReleaseGateCheckType.ErrorRate5xx => "error-rate-5xx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemRollingReleaseGateCheckType? ToEnum(string value)
        {
            return value switch
            {
                "error-rate-5xx" => GetProjectsResponseVariant1ItemRollingReleaseGateCheckType.ErrorRate5xx,
                _ => null,
            };
        }
    }
}
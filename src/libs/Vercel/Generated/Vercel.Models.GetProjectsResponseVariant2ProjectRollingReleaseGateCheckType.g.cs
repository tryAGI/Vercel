
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The metric this check evaluates.
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectRollingReleaseGateCheckType
    {
        /// <summary>
        /// 
        /// </summary>
        ErrorRate5xx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant2ProjectRollingReleaseGateCheckTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectRollingReleaseGateCheckType value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectRollingReleaseGateCheckType.ErrorRate5xx => "error-rate-5xx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectRollingReleaseGateCheckType? ToEnum(string value)
        {
            return value switch
            {
                "error-rate-5xx" => GetProjectsResponseVariant2ProjectRollingReleaseGateCheckType.ErrorRate5xx,
                _ => null,
            };
        }
    }
}
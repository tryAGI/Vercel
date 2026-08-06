
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The metric this check evaluates.
    /// </summary>
    public enum UpdateProjectResponseRollingReleaseGateCheckType
    {
        /// <summary>
        /// 
        /// </summary>
        ErrorRate5xx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseRollingReleaseGateCheckTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseRollingReleaseGateCheckType value)
        {
            return value switch
            {
                UpdateProjectResponseRollingReleaseGateCheckType.ErrorRate5xx => "error-rate-5xx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseRollingReleaseGateCheckType? ToEnum(string value)
        {
            return value switch
            {
                "error-rate-5xx" => UpdateProjectResponseRollingReleaseGateCheckType.ErrorRate5xx,
                _ => null,
            };
        }
    }
}
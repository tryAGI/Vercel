
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The metric this check evaluates.
    /// </summary>
    public enum UpdateMicrofrontendsResponseRollingReleaseGateCheckType
    {
        /// <summary>
        /// 
        /// </summary>
        ErrorRate5xx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrofrontendsResponseRollingReleaseGateCheckTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseRollingReleaseGateCheckType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseRollingReleaseGateCheckType.ErrorRate5xx => "error-rate-5xx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseRollingReleaseGateCheckType? ToEnum(string value)
        {
            return value switch
            {
                "error-rate-5xx" => UpdateMicrofrontendsResponseRollingReleaseGateCheckType.ErrorRate5xx,
                _ => null,
            };
        }
    }
}
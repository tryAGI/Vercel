
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseFunctionsMaxDuration
    {
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseFunctionsMaxDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseFunctionsMaxDuration value)
        {
            return value switch
            {
                CancelDeploymentResponseFunctionsMaxDuration.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseFunctionsMaxDuration? ToEnum(string value)
        {
            return value switch
            {
                "max" => CancelDeploymentResponseFunctionsMaxDuration.Max,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseOomReport
    {
        /// <summary>
        /// 
        /// </summary>
        OutOfMemory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseOomReportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseOomReport value)
        {
            return value switch
            {
                CancelDeploymentResponseOomReport.OutOfMemory => "out-of-memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseOomReport? ToEnum(string value)
        {
            return value switch
            {
                "out-of-memory" => CancelDeploymentResponseOomReport.OutOfMemory,
                _ => null,
            };
        }
    }
}
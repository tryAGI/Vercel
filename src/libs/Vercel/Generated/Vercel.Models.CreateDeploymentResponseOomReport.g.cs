
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseOomReport
    {
        /// <summary>
        /// 
        /// </summary>
        OutOfMemory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseOomReportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseOomReport value)
        {
            return value switch
            {
                CreateDeploymentResponseOomReport.OutOfMemory => "out-of-memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseOomReport? ToEnum(string value)
        {
            return value switch
            {
                "out-of-memory" => CreateDeploymentResponseOomReport.OutOfMemory,
                _ => null,
            };
        }
    }
}
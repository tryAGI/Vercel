
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentResponseVariant2OomReport
    {
        /// <summary>
        ///
        /// </summary>
        OutOfMemory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2OomReportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2OomReport value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2OomReport.OutOfMemory => "out-of-memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2OomReport? ToEnum(string value)
        {
            return value switch
            {
                "out-of-memory" => CreateDeploymentResponseVariant2OomReport.OutOfMemory,
                _ => null,
            };
        }
    }
}
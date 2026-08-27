
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant3OomReport
    {
        /// <summary>
        ///
        /// </summary>
        OutOfMemory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant3OomReportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3OomReport value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3OomReport.OutOfMemory => "out-of-memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3OomReport? ToEnum(string value)
        {
            return value switch
            {
                "out-of-memory" => GetDeploymentResponseVariant3OomReport.OutOfMemory,
                _ => null,
            };
        }
    }
}
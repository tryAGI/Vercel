
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1OomReport
    {
        /// <summary>
        /// 
        /// </summary>
        OutOfMemory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1OomReportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1OomReport value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1OomReport.OutOfMemory => "out-of-memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1OomReport? ToEnum(string value)
        {
            return value switch
            {
                "out-of-memory" => GetDeploymentResponseVariant1OomReport.OutOfMemory,
                _ => null,
            };
        }
    }
}
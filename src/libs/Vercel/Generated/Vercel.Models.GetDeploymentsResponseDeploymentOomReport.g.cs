
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Indicates if the deployment encountered an out-of-memory error.<br/>
    /// Example: out-of-memory
    /// </summary>
    public enum GetDeploymentsResponseDeploymentOomReport
    {
        /// <summary>
        /// 
        /// </summary>
        OutOfMemory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentsResponseDeploymentOomReportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentOomReport value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentOomReport.OutOfMemory => "out-of-memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentOomReport? ToEnum(string value)
        {
            return value switch
            {
                "out-of-memory" => GetDeploymentsResponseDeploymentOomReport.OutOfMemory,
                _ => null,
            };
        }
    }
}
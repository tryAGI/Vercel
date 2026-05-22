
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentCheckRunResponseVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant2Status value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant2Status.Completed => "completed",
                GetDeploymentCheckRunResponseVariant2Status.Queued => "queued",
                GetDeploymentCheckRunResponseVariant2Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetDeploymentCheckRunResponseVariant2Status.Completed,
                "queued" => GetDeploymentCheckRunResponseVariant2Status.Queued,
                "running" => GetDeploymentCheckRunResponseVariant2Status.Running,
                _ => null,
            };
        }
    }
}
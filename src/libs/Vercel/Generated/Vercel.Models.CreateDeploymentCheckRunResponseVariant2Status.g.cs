
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseVariant2Status
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
    public static class CreateDeploymentCheckRunResponseVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseVariant2Status value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseVariant2Status.Completed => "completed",
                CreateDeploymentCheckRunResponseVariant2Status.Queued => "queued",
                CreateDeploymentCheckRunResponseVariant2Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CreateDeploymentCheckRunResponseVariant2Status.Completed,
                "queued" => CreateDeploymentCheckRunResponseVariant2Status.Queued,
                "running" => CreateDeploymentCheckRunResponseVariant2Status.Running,
                _ => null,
            };
        }
    }
}
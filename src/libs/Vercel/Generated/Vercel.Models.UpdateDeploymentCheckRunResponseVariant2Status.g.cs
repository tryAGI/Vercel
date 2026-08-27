
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseVariant2Status
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
    public static class UpdateDeploymentCheckRunResponseVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseVariant2Status value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseVariant2Status.Completed => "completed",
                UpdateDeploymentCheckRunResponseVariant2Status.Queued => "queued",
                UpdateDeploymentCheckRunResponseVariant2Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UpdateDeploymentCheckRunResponseVariant2Status.Completed,
                "queued" => UpdateDeploymentCheckRunResponseVariant2Status.Queued,
                "running" => UpdateDeploymentCheckRunResponseVariant2Status.Running,
                _ => null,
            };
        }
    }
}
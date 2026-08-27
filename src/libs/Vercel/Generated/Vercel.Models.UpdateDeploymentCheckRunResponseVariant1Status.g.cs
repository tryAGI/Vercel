
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseVariant1Status
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
    public static class UpdateDeploymentCheckRunResponseVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseVariant1Status value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseVariant1Status.Completed => "completed",
                UpdateDeploymentCheckRunResponseVariant1Status.Queued => "queued",
                UpdateDeploymentCheckRunResponseVariant1Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UpdateDeploymentCheckRunResponseVariant1Status.Completed,
                "queued" => UpdateDeploymentCheckRunResponseVariant1Status.Queued,
                "running" => UpdateDeploymentCheckRunResponseVariant1Status.Running,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentCheckRunResponseVariant1Status
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
    public static class CreateDeploymentCheckRunResponseVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseVariant1Status value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseVariant1Status.Completed => "completed",
                CreateDeploymentCheckRunResponseVariant1Status.Queued => "queued",
                CreateDeploymentCheckRunResponseVariant1Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CreateDeploymentCheckRunResponseVariant1Status.Completed,
                "queued" => CreateDeploymentCheckRunResponseVariant1Status.Queued,
                "running" => CreateDeploymentCheckRunResponseVariant1Status.Running,
                _ => null,
            };
        }
    }
}
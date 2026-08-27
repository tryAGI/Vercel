
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant1Status
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
    public static class GetDeploymentCheckRunResponseVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant1Status value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant1Status.Completed => "completed",
                GetDeploymentCheckRunResponseVariant1Status.Queued => "queued",
                GetDeploymentCheckRunResponseVariant1Status.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetDeploymentCheckRunResponseVariant1Status.Completed,
                "queued" => GetDeploymentCheckRunResponseVariant1Status.Queued,
                "running" => GetDeploymentCheckRunResponseVariant1Status.Running,
                _ => null,
            };
        }
    }
}
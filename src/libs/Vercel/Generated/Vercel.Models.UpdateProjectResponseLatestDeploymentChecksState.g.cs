
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectResponseLatestDeploymentChecksState
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Registered,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseLatestDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseLatestDeploymentChecksState value)
        {
            return value switch
            {
                UpdateProjectResponseLatestDeploymentChecksState.Completed => "completed",
                UpdateProjectResponseLatestDeploymentChecksState.Registered => "registered",
                UpdateProjectResponseLatestDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseLatestDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => UpdateProjectResponseLatestDeploymentChecksState.Completed,
                "registered" => UpdateProjectResponseLatestDeploymentChecksState.Registered,
                "running" => UpdateProjectResponseLatestDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}
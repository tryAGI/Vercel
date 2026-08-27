
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseLatestDeploymentChecksState
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
    public static class CreateProjectResponseLatestDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseLatestDeploymentChecksState value)
        {
            return value switch
            {
                CreateProjectResponseLatestDeploymentChecksState.Completed => "completed",
                CreateProjectResponseLatestDeploymentChecksState.Registered => "registered",
                CreateProjectResponseLatestDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseLatestDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => CreateProjectResponseLatestDeploymentChecksState.Completed,
                "registered" => CreateProjectResponseLatestDeploymentChecksState.Registered,
                "running" => CreateProjectResponseLatestDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}
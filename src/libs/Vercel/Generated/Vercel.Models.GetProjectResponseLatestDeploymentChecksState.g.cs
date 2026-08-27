
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseLatestDeploymentChecksState
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
    public static class GetProjectResponseLatestDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLatestDeploymentChecksState value)
        {
            return value switch
            {
                GetProjectResponseLatestDeploymentChecksState.Completed => "completed",
                GetProjectResponseLatestDeploymentChecksState.Registered => "registered",
                GetProjectResponseLatestDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLatestDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetProjectResponseLatestDeploymentChecksState.Completed,
                "registered" => GetProjectResponseLatestDeploymentChecksState.Registered,
                "running" => GetProjectResponseLatestDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}
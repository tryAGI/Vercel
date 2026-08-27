
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectLatestDeploymentChecksState
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
    public static class GetProjectsResponseVariant2ProjectLatestDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectLatestDeploymentChecksState value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectLatestDeploymentChecksState.Completed => "completed",
                GetProjectsResponseVariant2ProjectLatestDeploymentChecksState.Registered => "registered",
                GetProjectsResponseVariant2ProjectLatestDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectLatestDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetProjectsResponseVariant2ProjectLatestDeploymentChecksState.Completed,
                "registered" => GetProjectsResponseVariant2ProjectLatestDeploymentChecksState.Registered,
                "running" => GetProjectsResponseVariant2ProjectLatestDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}
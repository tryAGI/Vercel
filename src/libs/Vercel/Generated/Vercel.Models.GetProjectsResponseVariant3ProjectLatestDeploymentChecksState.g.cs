
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectLatestDeploymentChecksState
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
    public static class GetProjectsResponseVariant3ProjectLatestDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectLatestDeploymentChecksState value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectLatestDeploymentChecksState.Completed => "completed",
                GetProjectsResponseVariant3ProjectLatestDeploymentChecksState.Registered => "registered",
                GetProjectsResponseVariant3ProjectLatestDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectLatestDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetProjectsResponseVariant3ProjectLatestDeploymentChecksState.Completed,
                "registered" => GetProjectsResponseVariant3ProjectLatestDeploymentChecksState.Registered,
                "running" => GetProjectsResponseVariant3ProjectLatestDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}
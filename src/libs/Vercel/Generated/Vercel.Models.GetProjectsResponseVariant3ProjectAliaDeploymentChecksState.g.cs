
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAliaDeploymentChecksState
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
    public static class GetProjectsResponseVariant3ProjectAliaDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAliaDeploymentChecksState value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAliaDeploymentChecksState.Completed => "completed",
                GetProjectsResponseVariant3ProjectAliaDeploymentChecksState.Registered => "registered",
                GetProjectsResponseVariant3ProjectAliaDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAliaDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetProjectsResponseVariant3ProjectAliaDeploymentChecksState.Completed,
                "registered" => GetProjectsResponseVariant3ProjectAliaDeploymentChecksState.Registered,
                "running" => GetProjectsResponseVariant3ProjectAliaDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}
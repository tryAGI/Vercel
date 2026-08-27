
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectAliaDeploymentChecksState
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
    public static class GetProjectsResponseVariant2ProjectAliaDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectAliaDeploymentChecksState value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectAliaDeploymentChecksState.Completed => "completed",
                GetProjectsResponseVariant2ProjectAliaDeploymentChecksState.Registered => "registered",
                GetProjectsResponseVariant2ProjectAliaDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectAliaDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetProjectsResponseVariant2ProjectAliaDeploymentChecksState.Completed,
                "registered" => GetProjectsResponseVariant2ProjectAliaDeploymentChecksState.Registered,
                "running" => GetProjectsResponseVariant2ProjectAliaDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}
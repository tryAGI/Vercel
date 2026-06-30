
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemLatestDeploymentChecksState
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
    public static class GetProjectsResponseVariant1ItemLatestDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemLatestDeploymentChecksState value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemLatestDeploymentChecksState.Completed => "completed",
                GetProjectsResponseVariant1ItemLatestDeploymentChecksState.Registered => "registered",
                GetProjectsResponseVariant1ItemLatestDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemLatestDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetProjectsResponseVariant1ItemLatestDeploymentChecksState.Completed,
                "registered" => GetProjectsResponseVariant1ItemLatestDeploymentChecksState.Registered,
                "running" => GetProjectsResponseVariant1ItemLatestDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}
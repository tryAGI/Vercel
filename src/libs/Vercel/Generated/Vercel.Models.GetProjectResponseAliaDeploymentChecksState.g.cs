
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseAliaDeploymentChecksState
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
    public static class GetProjectResponseAliaDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAliaDeploymentChecksState value)
        {
            return value switch
            {
                GetProjectResponseAliaDeploymentChecksState.Completed => "completed",
                GetProjectResponseAliaDeploymentChecksState.Registered => "registered",
                GetProjectResponseAliaDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAliaDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetProjectResponseAliaDeploymentChecksState.Completed,
                "registered" => GetProjectResponseAliaDeploymentChecksState.Registered,
                "running" => GetProjectResponseAliaDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}
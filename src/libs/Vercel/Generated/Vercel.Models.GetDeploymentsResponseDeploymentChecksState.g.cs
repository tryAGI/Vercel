
#nullable enable

namespace Vercel
{
    /// <summary>
    /// State of all registered checks
    /// </summary>
    public enum GetDeploymentsResponseDeploymentChecksState
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
    public static class GetDeploymentsResponseDeploymentChecksStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentChecksState value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentChecksState.Completed => "completed",
                GetDeploymentsResponseDeploymentChecksState.Registered => "registered",
                GetDeploymentsResponseDeploymentChecksState.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentChecksState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetDeploymentsResponseDeploymentChecksState.Completed,
                "registered" => GetDeploymentsResponseDeploymentChecksState.Registered,
                "running" => GetDeploymentsResponseDeploymentChecksState.Running,
                _ => null,
            };
        }
    }
}
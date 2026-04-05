
#nullable enable

namespace Vercel
{
    /// <summary>
    /// In which state is the deployment.<br/>
    /// Example: READY
    /// </summary>
    public enum GetDeploymentsResponseDeploymentState
    {
        /// <summary>
        /// 
        /// </summary>
        Building,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Initializing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentsResponseDeploymentStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentState value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentState.Building => "BUILDING",
                GetDeploymentsResponseDeploymentState.Canceled => "CANCELED",
                GetDeploymentsResponseDeploymentState.Deleted => "DELETED",
                GetDeploymentsResponseDeploymentState.Error => "ERROR",
                GetDeploymentsResponseDeploymentState.Initializing => "INITIALIZING",
                GetDeploymentsResponseDeploymentState.Queued => "QUEUED",
                GetDeploymentsResponseDeploymentState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => GetDeploymentsResponseDeploymentState.Building,
                "CANCELED" => GetDeploymentsResponseDeploymentState.Canceled,
                "DELETED" => GetDeploymentsResponseDeploymentState.Deleted,
                "ERROR" => GetDeploymentsResponseDeploymentState.Error,
                "INITIALIZING" => GetDeploymentsResponseDeploymentState.Initializing,
                "QUEUED" => GetDeploymentsResponseDeploymentState.Queued,
                "READY" => GetDeploymentsResponseDeploymentState.Ready,
                _ => null,
            };
        }
    }
}
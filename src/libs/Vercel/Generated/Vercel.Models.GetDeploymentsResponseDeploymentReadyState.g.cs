
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentsResponseDeploymentReadyState
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
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
    public static class GetDeploymentsResponseDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentReadyState value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentReadyState.Blocked => "BLOCKED",
                GetDeploymentsResponseDeploymentReadyState.Building => "BUILDING",
                GetDeploymentsResponseDeploymentReadyState.Canceled => "CANCELED",
                GetDeploymentsResponseDeploymentReadyState.Deleted => "DELETED",
                GetDeploymentsResponseDeploymentReadyState.Error => "ERROR",
                GetDeploymentsResponseDeploymentReadyState.Initializing => "INITIALIZING",
                GetDeploymentsResponseDeploymentReadyState.Queued => "QUEUED",
                GetDeploymentsResponseDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => GetDeploymentsResponseDeploymentReadyState.Blocked,
                "BUILDING" => GetDeploymentsResponseDeploymentReadyState.Building,
                "CANCELED" => GetDeploymentsResponseDeploymentReadyState.Canceled,
                "DELETED" => GetDeploymentsResponseDeploymentReadyState.Deleted,
                "ERROR" => GetDeploymentsResponseDeploymentReadyState.Error,
                "INITIALIZING" => GetDeploymentsResponseDeploymentReadyState.Initializing,
                "QUEUED" => GetDeploymentsResponseDeploymentReadyState.Queued,
                "READY" => GetDeploymentsResponseDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}
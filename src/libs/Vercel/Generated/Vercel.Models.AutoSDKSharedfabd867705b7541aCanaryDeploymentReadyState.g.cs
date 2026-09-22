
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState
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
    public static class AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState value)
        {
            return value switch
            {
                AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Blocked => "BLOCKED",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Building => "BUILDING",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Canceled => "CANCELED",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Error => "ERROR",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Initializing => "INITIALIZING",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Queued => "QUEUED",
                AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Blocked,
                "BUILDING" => AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Building,
                "CANCELED" => AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Canceled,
                "ERROR" => AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Error,
                "INITIALIZING" => AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Initializing,
                "QUEUED" => AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Queued,
                "READY" => AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}
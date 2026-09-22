
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the deployment depending on the process of deploying, or if it is ready or in an error state<br/>
    /// Example: READY
    /// </summary>
    public enum AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState
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
    public static class AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState value)
        {
            return value switch
            {
                AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Blocked => "BLOCKED",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Building => "BUILDING",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Canceled => "CANCELED",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Error => "ERROR",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Initializing => "INITIALIZING",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Queued => "QUEUED",
                AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BLOCKED" => AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Blocked,
                "BUILDING" => AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Building,
                "CANCELED" => AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Canceled,
                "ERROR" => AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Error,
                "INITIALIZING" => AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Initializing,
                "QUEUED" => AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Queued,
                "READY" => AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState.Ready,
                _ => null,
            };
        }
    }
}
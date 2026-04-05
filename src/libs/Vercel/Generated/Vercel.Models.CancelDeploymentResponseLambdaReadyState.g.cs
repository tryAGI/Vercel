
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseLambdaReadyState
    {
        /// <summary>
        /// 
        /// </summary>
        Building,
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
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseLambdaReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseLambdaReadyState value)
        {
            return value switch
            {
                CancelDeploymentResponseLambdaReadyState.Building => "BUILDING",
                CancelDeploymentResponseLambdaReadyState.Error => "ERROR",
                CancelDeploymentResponseLambdaReadyState.Initializing => "INITIALIZING",
                CancelDeploymentResponseLambdaReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseLambdaReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => CancelDeploymentResponseLambdaReadyState.Building,
                "ERROR" => CancelDeploymentResponseLambdaReadyState.Error,
                "INITIALIZING" => CancelDeploymentResponseLambdaReadyState.Initializing,
                "READY" => CancelDeploymentResponseLambdaReadyState.Ready,
                _ => null,
            };
        }
    }
}
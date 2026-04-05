
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseLambdaReadyState
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
    public static class CreateDeploymentResponseLambdaReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseLambdaReadyState value)
        {
            return value switch
            {
                CreateDeploymentResponseLambdaReadyState.Building => "BUILDING",
                CreateDeploymentResponseLambdaReadyState.Error => "ERROR",
                CreateDeploymentResponseLambdaReadyState.Initializing => "INITIALIZING",
                CreateDeploymentResponseLambdaReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseLambdaReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => CreateDeploymentResponseLambdaReadyState.Building,
                "ERROR" => CreateDeploymentResponseLambdaReadyState.Error,
                "INITIALIZING" => CreateDeploymentResponseLambdaReadyState.Initializing,
                "READY" => CreateDeploymentResponseLambdaReadyState.Ready,
                _ => null,
            };
        }
    }
}
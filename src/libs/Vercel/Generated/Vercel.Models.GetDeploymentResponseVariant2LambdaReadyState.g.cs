
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2LambdaReadyState
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
    public static class GetDeploymentResponseVariant2LambdaReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2LambdaReadyState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2LambdaReadyState.Building => "BUILDING",
                GetDeploymentResponseVariant2LambdaReadyState.Error => "ERROR",
                GetDeploymentResponseVariant2LambdaReadyState.Initializing => "INITIALIZING",
                GetDeploymentResponseVariant2LambdaReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2LambdaReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => GetDeploymentResponseVariant2LambdaReadyState.Building,
                "ERROR" => GetDeploymentResponseVariant2LambdaReadyState.Error,
                "INITIALIZING" => GetDeploymentResponseVariant2LambdaReadyState.Initializing,
                "READY" => GetDeploymentResponseVariant2LambdaReadyState.Ready,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant3LambdaReadyState
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
    public static class GetDeploymentResponseVariant3LambdaReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3LambdaReadyState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3LambdaReadyState.Building => "BUILDING",
                GetDeploymentResponseVariant3LambdaReadyState.Error => "ERROR",
                GetDeploymentResponseVariant3LambdaReadyState.Initializing => "INITIALIZING",
                GetDeploymentResponseVariant3LambdaReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3LambdaReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => GetDeploymentResponseVariant3LambdaReadyState.Building,
                "ERROR" => GetDeploymentResponseVariant3LambdaReadyState.Error,
                "INITIALIZING" => GetDeploymentResponseVariant3LambdaReadyState.Initializing,
                "READY" => GetDeploymentResponseVariant3LambdaReadyState.Ready,
                _ => null,
            };
        }
    }
}
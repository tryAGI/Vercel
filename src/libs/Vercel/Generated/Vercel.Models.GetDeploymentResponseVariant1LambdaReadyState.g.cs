
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1LambdaReadyState
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
    public static class GetDeploymentResponseVariant1LambdaReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1LambdaReadyState value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1LambdaReadyState.Building => "BUILDING",
                GetDeploymentResponseVariant1LambdaReadyState.Error => "ERROR",
                GetDeploymentResponseVariant1LambdaReadyState.Initializing => "INITIALIZING",
                GetDeploymentResponseVariant1LambdaReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1LambdaReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => GetDeploymentResponseVariant1LambdaReadyState.Building,
                "ERROR" => GetDeploymentResponseVariant1LambdaReadyState.Error,
                "INITIALIZING" => GetDeploymentResponseVariant1LambdaReadyState.Initializing,
                "READY" => GetDeploymentResponseVariant1LambdaReadyState.Ready,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentResponseVariant2LambdaReadyState
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
    public static class CreateDeploymentResponseVariant2LambdaReadyStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2LambdaReadyState value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2LambdaReadyState.Building => "BUILDING",
                CreateDeploymentResponseVariant2LambdaReadyState.Error => "ERROR",
                CreateDeploymentResponseVariant2LambdaReadyState.Initializing => "INITIALIZING",
                CreateDeploymentResponseVariant2LambdaReadyState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2LambdaReadyState? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => CreateDeploymentResponseVariant2LambdaReadyState.Building,
                "ERROR" => CreateDeploymentResponseVariant2LambdaReadyState.Error,
                "INITIALIZING" => CreateDeploymentResponseVariant2LambdaReadyState.Initializing,
                "READY" => CreateDeploymentResponseVariant2LambdaReadyState.Ready,
                _ => null,
            };
        }
    }
}
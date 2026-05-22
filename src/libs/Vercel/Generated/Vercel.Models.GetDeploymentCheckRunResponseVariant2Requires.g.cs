
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant2Requires
    {
        /// <summary>
        /// 
        /// </summary>
        BuildReady,
        /// <summary>
        /// 
        /// </summary>
        DeploymentUrl,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentCheckRunResponseVariant2RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant2Requires value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant2Requires.BuildReady => "build-ready",
                GetDeploymentCheckRunResponseVariant2Requires.DeploymentUrl => "deployment-url",
                GetDeploymentCheckRunResponseVariant2Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant2Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => GetDeploymentCheckRunResponseVariant2Requires.BuildReady,
                "deployment-url" => GetDeploymentCheckRunResponseVariant2Requires.DeploymentUrl,
                "none" => GetDeploymentCheckRunResponseVariant2Requires.None,
                _ => null,
            };
        }
    }
}
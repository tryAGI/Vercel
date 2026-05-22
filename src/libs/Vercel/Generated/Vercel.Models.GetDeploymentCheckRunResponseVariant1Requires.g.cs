
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseVariant1Requires
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
    public static class GetDeploymentCheckRunResponseVariant1RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseVariant1Requires value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseVariant1Requires.BuildReady => "build-ready",
                GetDeploymentCheckRunResponseVariant1Requires.DeploymentUrl => "deployment-url",
                GetDeploymentCheckRunResponseVariant1Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseVariant1Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => GetDeploymentCheckRunResponseVariant1Requires.BuildReady,
                "deployment-url" => GetDeploymentCheckRunResponseVariant1Requires.DeploymentUrl,
                "none" => GetDeploymentCheckRunResponseVariant1Requires.None,
                _ => null,
            };
        }
    }
}
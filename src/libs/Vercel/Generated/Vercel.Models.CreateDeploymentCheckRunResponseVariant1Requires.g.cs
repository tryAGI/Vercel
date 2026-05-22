
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseVariant1Requires
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
    public static class CreateDeploymentCheckRunResponseVariant1RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseVariant1Requires value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseVariant1Requires.BuildReady => "build-ready",
                CreateDeploymentCheckRunResponseVariant1Requires.DeploymentUrl => "deployment-url",
                CreateDeploymentCheckRunResponseVariant1Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseVariant1Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => CreateDeploymentCheckRunResponseVariant1Requires.BuildReady,
                "deployment-url" => CreateDeploymentCheckRunResponseVariant1Requires.DeploymentUrl,
                "none" => CreateDeploymentCheckRunResponseVariant1Requires.None,
                _ => null,
            };
        }
    }
}
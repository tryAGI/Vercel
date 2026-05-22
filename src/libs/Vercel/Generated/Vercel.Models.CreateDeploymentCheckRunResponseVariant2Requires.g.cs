
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseVariant2Requires
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
    public static class CreateDeploymentCheckRunResponseVariant2RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseVariant2Requires value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseVariant2Requires.BuildReady => "build-ready",
                CreateDeploymentCheckRunResponseVariant2Requires.DeploymentUrl => "deployment-url",
                CreateDeploymentCheckRunResponseVariant2Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseVariant2Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => CreateDeploymentCheckRunResponseVariant2Requires.BuildReady,
                "deployment-url" => CreateDeploymentCheckRunResponseVariant2Requires.DeploymentUrl,
                "none" => CreateDeploymentCheckRunResponseVariant2Requires.None,
                _ => null,
            };
        }
    }
}
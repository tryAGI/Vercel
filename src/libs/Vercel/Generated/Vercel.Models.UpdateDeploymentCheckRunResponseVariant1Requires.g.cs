
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseVariant1Requires
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
    public static class UpdateDeploymentCheckRunResponseVariant1RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseVariant1Requires value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseVariant1Requires.BuildReady => "build-ready",
                UpdateDeploymentCheckRunResponseVariant1Requires.DeploymentUrl => "deployment-url",
                UpdateDeploymentCheckRunResponseVariant1Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseVariant1Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => UpdateDeploymentCheckRunResponseVariant1Requires.BuildReady,
                "deployment-url" => UpdateDeploymentCheckRunResponseVariant1Requires.DeploymentUrl,
                "none" => UpdateDeploymentCheckRunResponseVariant1Requires.None,
                _ => null,
            };
        }
    }
}
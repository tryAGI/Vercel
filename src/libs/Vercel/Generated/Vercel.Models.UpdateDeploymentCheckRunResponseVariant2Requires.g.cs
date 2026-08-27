
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseVariant2Requires
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
    public static class UpdateDeploymentCheckRunResponseVariant2RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseVariant2Requires value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseVariant2Requires.BuildReady => "build-ready",
                UpdateDeploymentCheckRunResponseVariant2Requires.DeploymentUrl => "deployment-url",
                UpdateDeploymentCheckRunResponseVariant2Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseVariant2Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => UpdateDeploymentCheckRunResponseVariant2Requires.BuildReady,
                "deployment-url" => UpdateDeploymentCheckRunResponseVariant2Requires.DeploymentUrl,
                "none" => UpdateDeploymentCheckRunResponseVariant2Requires.None,
                _ => null,
            };
        }
    }
}
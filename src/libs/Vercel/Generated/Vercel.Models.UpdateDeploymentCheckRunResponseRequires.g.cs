
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseRequires
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
    public static class UpdateDeploymentCheckRunResponseRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseRequires value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseRequires.BuildReady => "build-ready",
                UpdateDeploymentCheckRunResponseRequires.DeploymentUrl => "deployment-url",
                UpdateDeploymentCheckRunResponseRequires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => UpdateDeploymentCheckRunResponseRequires.BuildReady,
                "deployment-url" => UpdateDeploymentCheckRunResponseRequires.DeploymentUrl,
                "none" => UpdateDeploymentCheckRunResponseRequires.None,
                _ => null,
            };
        }
    }
}
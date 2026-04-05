
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseRequires
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
    public static class CreateDeploymentCheckRunResponseRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseRequires value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseRequires.BuildReady => "build-ready",
                CreateDeploymentCheckRunResponseRequires.DeploymentUrl => "deployment-url",
                CreateDeploymentCheckRunResponseRequires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => CreateDeploymentCheckRunResponseRequires.BuildReady,
                "deployment-url" => CreateDeploymentCheckRunResponseRequires.DeploymentUrl,
                "none" => CreateDeploymentCheckRunResponseRequires.None,
                _ => null,
            };
        }
    }
}
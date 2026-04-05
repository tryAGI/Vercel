
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseRequires
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
    public static class GetDeploymentCheckRunResponseRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseRequires value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseRequires.BuildReady => "build-ready",
                GetDeploymentCheckRunResponseRequires.DeploymentUrl => "deployment-url",
                GetDeploymentCheckRunResponseRequires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => GetDeploymentCheckRunResponseRequires.BuildReady,
                "deployment-url" => GetDeploymentCheckRunResponseRequires.DeploymentUrl,
                "none" => GetDeploymentCheckRunResponseRequires.None,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunRequires
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
    public static class ListDeploymentCheckRunsResponseRunRequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunRequires value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunRequires.BuildReady => "build-ready",
                ListDeploymentCheckRunsResponseRunRequires.DeploymentUrl => "deployment-url",
                ListDeploymentCheckRunsResponseRunRequires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunRequires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => ListDeploymentCheckRunsResponseRunRequires.BuildReady,
                "deployment-url" => ListDeploymentCheckRunsResponseRunRequires.DeploymentUrl,
                "none" => ListDeploymentCheckRunsResponseRunRequires.None,
                _ => null,
            };
        }
    }
}
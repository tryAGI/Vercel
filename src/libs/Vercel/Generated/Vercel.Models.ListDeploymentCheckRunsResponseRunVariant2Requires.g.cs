
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunVariant2Requires
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
    public static class ListDeploymentCheckRunsResponseRunVariant2RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunVariant2Requires value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunVariant2Requires.BuildReady => "build-ready",
                ListDeploymentCheckRunsResponseRunVariant2Requires.DeploymentUrl => "deployment-url",
                ListDeploymentCheckRunsResponseRunVariant2Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunVariant2Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => ListDeploymentCheckRunsResponseRunVariant2Requires.BuildReady,
                "deployment-url" => ListDeploymentCheckRunsResponseRunVariant2Requires.DeploymentUrl,
                "none" => ListDeploymentCheckRunsResponseRunVariant2Requires.None,
                _ => null,
            };
        }
    }
}
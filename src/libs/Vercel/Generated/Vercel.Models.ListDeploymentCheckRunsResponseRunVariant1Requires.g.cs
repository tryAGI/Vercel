
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum ListDeploymentCheckRunsResponseRunVariant1Requires
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
    public static class ListDeploymentCheckRunsResponseRunVariant1RequiresExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDeploymentCheckRunsResponseRunVariant1Requires value)
        {
            return value switch
            {
                ListDeploymentCheckRunsResponseRunVariant1Requires.BuildReady => "build-ready",
                ListDeploymentCheckRunsResponseRunVariant1Requires.DeploymentUrl => "deployment-url",
                ListDeploymentCheckRunsResponseRunVariant1Requires.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDeploymentCheckRunsResponseRunVariant1Requires? ToEnum(string value)
        {
            return value switch
            {
                "build-ready" => ListDeploymentCheckRunsResponseRunVariant1Requires.BuildReady,
                "deployment-url" => ListDeploymentCheckRunsResponseRunVariant1Requires.DeploymentUrl,
                "none" => ListDeploymentCheckRunsResponseRunVariant1Requires.None,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectLatestDeploymentReadySubstate
    {
        /// <summary>
        ///
        /// </summary>
        Promoted,
        /// <summary>
        ///
        /// </summary>
        Rolling,
        /// <summary>
        ///
        /// </summary>
        Staged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectLatestDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectLatestDeploymentReadySubstate value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectLatestDeploymentReadySubstate.Promoted => "PROMOTED",
                GetProjectsResponseVariant3ProjectLatestDeploymentReadySubstate.Rolling => "ROLLING",
                GetProjectsResponseVariant3ProjectLatestDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectLatestDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetProjectsResponseVariant3ProjectLatestDeploymentReadySubstate.Promoted,
                "ROLLING" => GetProjectsResponseVariant3ProjectLatestDeploymentReadySubstate.Rolling,
                "STAGED" => GetProjectsResponseVariant3ProjectLatestDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}
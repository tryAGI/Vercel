
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseLatestDeploymentReadySubstate
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
    public static class GetProjectResponseLatestDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseLatestDeploymentReadySubstate value)
        {
            return value switch
            {
                GetProjectResponseLatestDeploymentReadySubstate.Promoted => "PROMOTED",
                GetProjectResponseLatestDeploymentReadySubstate.Rolling => "ROLLING",
                GetProjectResponseLatestDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseLatestDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetProjectResponseLatestDeploymentReadySubstate.Promoted,
                "ROLLING" => GetProjectResponseLatestDeploymentReadySubstate.Rolling,
                "STAGED" => GetProjectResponseLatestDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}
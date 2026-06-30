
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseLatestDeploymentReadySubstate
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
    public static class UpdateProjectResponseLatestDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseLatestDeploymentReadySubstate value)
        {
            return value switch
            {
                UpdateProjectResponseLatestDeploymentReadySubstate.Promoted => "PROMOTED",
                UpdateProjectResponseLatestDeploymentReadySubstate.Rolling => "ROLLING",
                UpdateProjectResponseLatestDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseLatestDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => UpdateProjectResponseLatestDeploymentReadySubstate.Promoted,
                "ROLLING" => UpdateProjectResponseLatestDeploymentReadySubstate.Rolling,
                "STAGED" => UpdateProjectResponseLatestDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseLatestDeploymentReadySubstate
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
    public static class CreateProjectResponseLatestDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseLatestDeploymentReadySubstate value)
        {
            return value switch
            {
                CreateProjectResponseLatestDeploymentReadySubstate.Promoted => "PROMOTED",
                CreateProjectResponseLatestDeploymentReadySubstate.Rolling => "ROLLING",
                CreateProjectResponseLatestDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseLatestDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => CreateProjectResponseLatestDeploymentReadySubstate.Promoted,
                "ROLLING" => CreateProjectResponseLatestDeploymentReadySubstate.Rolling,
                "STAGED" => CreateProjectResponseLatestDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}
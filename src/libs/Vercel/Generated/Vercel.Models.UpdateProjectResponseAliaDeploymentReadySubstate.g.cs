
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateProjectResponseAliaDeploymentReadySubstate
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
    public static class UpdateProjectResponseAliaDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseAliaDeploymentReadySubstate value)
        {
            return value switch
            {
                UpdateProjectResponseAliaDeploymentReadySubstate.Promoted => "PROMOTED",
                UpdateProjectResponseAliaDeploymentReadySubstate.Rolling => "ROLLING",
                UpdateProjectResponseAliaDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseAliaDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => UpdateProjectResponseAliaDeploymentReadySubstate.Promoted,
                "ROLLING" => UpdateProjectResponseAliaDeploymentReadySubstate.Rolling,
                "STAGED" => UpdateProjectResponseAliaDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}
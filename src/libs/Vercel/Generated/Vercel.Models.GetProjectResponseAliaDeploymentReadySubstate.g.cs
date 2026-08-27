
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseAliaDeploymentReadySubstate
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
    public static class GetProjectResponseAliaDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseAliaDeploymentReadySubstate value)
        {
            return value switch
            {
                GetProjectResponseAliaDeploymentReadySubstate.Promoted => "PROMOTED",
                GetProjectResponseAliaDeploymentReadySubstate.Rolling => "ROLLING",
                GetProjectResponseAliaDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseAliaDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetProjectResponseAliaDeploymentReadySubstate.Promoted,
                "ROLLING" => GetProjectResponseAliaDeploymentReadySubstate.Rolling,
                "STAGED" => GetProjectResponseAliaDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}
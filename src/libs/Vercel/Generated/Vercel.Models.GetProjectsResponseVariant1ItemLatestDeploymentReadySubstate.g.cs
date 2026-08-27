
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant1ItemLatestDeploymentReadySubstate
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
    public static class GetProjectsResponseVariant1ItemLatestDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemLatestDeploymentReadySubstate value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemLatestDeploymentReadySubstate.Promoted => "PROMOTED",
                GetProjectsResponseVariant1ItemLatestDeploymentReadySubstate.Rolling => "ROLLING",
                GetProjectsResponseVariant1ItemLatestDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemLatestDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetProjectsResponseVariant1ItemLatestDeploymentReadySubstate.Promoted,
                "ROLLING" => GetProjectsResponseVariant1ItemLatestDeploymentReadySubstate.Rolling,
                "STAGED" => GetProjectsResponseVariant1ItemLatestDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}